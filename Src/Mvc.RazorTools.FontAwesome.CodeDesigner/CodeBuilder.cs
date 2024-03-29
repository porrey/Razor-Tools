﻿//
// Copyright(C) 2014-2020, Daniel M. Porrey. All rights reserved.
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published
// by the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program. If not, see http://www.gnu.org/licenses/.
//
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Mvc.RazorTools.FontAwesome.CodeDesigner
{
	public static class CodeBuilder
	{
		public static DirectoryInfo WithDirectory(this string name)
		{
			return new DirectoryInfo(name);
		}

		public static FileInfo[] ReadFiles(this DirectoryInfo directoryInfo)
		{
			return directoryInfo.GetFiles();
		}

		public static IDictionary<string, Font> BuildFontDictionary(this FileInfo[] files)
		{
			IDictionary<string, Font> fonts = new Dictionary<string, Font>();

			foreach (FileInfo file in files)
			{
				//
				// Read the json file.
				//
				string json = File.ReadAllText(file.FullName);

				//
				// Parse the json.
				//
				JArray jarray = JsonConvert.DeserializeObject<JArray>(json);

				//
				// Get the data array (list of font icons)
				//
				JToken items = jarray[2]["data"];

				foreach (JToken item in items)
				{
					//
					// Get the ID.
					//
					string id = item["id"].Value<string>();

					//
					// Get the membership (free or pro).
					//
					JToken membership = item["attributes"]["membership"];

					//
					// get the Unicode for the font.
					//
					string hexcode = item["attributes"]["unicode"].Value<string>();
					int unicode = Int32.Parse(hexcode, NumberStyles.HexNumber);

					//
					// Get the styles for this font icon that are free.
					//
					string[] freeStyles = (from tbl in (membership["free"] as JArray)
										   select tbl.Value<string>()).ToArray();

					if (freeStyles.Count() > 0)
					{
						//
						//
						//
						fonts.AddUpdateFont(id, LicenseType.Free, hexcode, unicode, freeStyles);
					}

					//
					// Get the styles for this font icon that are part of the pro edition.
					//
					string[] proStyles = (from tbl in (membership["pro"] as JArray)
										  select tbl.Value<string>()).ToArray();

					if (proStyles.Count() > 0)
					{
						//
						//
						//
						fonts.AddUpdateFont(id, LicenseType.Pro, hexcode, unicode, proStyles);
					}
				}
			}

			return fonts;
		}

		public static Font AddUpdateFont(this IDictionary<string, Font> fonts, string id, LicenseType license, string hexcode, int unicode, IList<string> styles)
		{
			Font currentFont = null;

			if (fonts.ContainsKey(id))
			{
				currentFont = fonts[id];
			}
			else
			{
				currentFont = new Font()
				{
					Id = id,
					HexCode = hexcode,
					Unicode = unicode,
					ClassName = id.ConvertToClassName()
				};

				fonts.Add(id, currentFont);
			}

			if (license == LicenseType.Free)
			{
				currentFont.License |= LicenseType.Free;
				currentFont.FreeStyles = styles;
			}
			else
			{
				currentFont.License |= LicenseType.Pro;
				currentFont.ProStyles = styles;
			}

			return currentFont;
		}

		public static string ConvertToClassName(this string id)
		{
			string returnValue = String.Empty;

			if (Char.IsDigit(id.ToCharArray()[0]))
			{
				id = $"X{id}";
			}

			CultureInfo cultureInfo = CultureInfo.CurrentCulture;
			TextInfo textInfo = cultureInfo.TextInfo;
			returnValue = textInfo.ToTitleCase(id).Replace("-", String.Empty);

			return returnValue;
		}

		public static (IDictionary<string, Font> Fonts, FileInfo Template) WithTemplate(this IDictionary<string, Font> fonts, string templatePath)
		{
			return (fonts, new FileInfo(templatePath));
		}

		public static (IDictionary<string, Font> Fonts, FileInfo Template) WithTemplate(this (IDictionary<string, Font> fonts, FileInfo Template) source, string templatePath)
		{
			return (source.fonts, new FileInfo(templatePath));
		}

		public static (IDictionary<string, Font> Fonts, FileInfo TemplateName) GenerateIconsClass(this (IDictionary<string, Font> Fonts, FileInfo Template) source)
		{
			StringBuilder code = new StringBuilder();

			//
			// Create the target path.
			//
			string targetPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}\{source.Template.Name}";

			//
			// Read the template.
			//
			string templateCode = File.ReadAllText(source.Template.FullName);

			//
			// Generate the source code.
			//
			var fonts = source.Fonts.Select(t => t.Value).OrderBy(t => t.Id);
			foreach (Font font in fonts)
			{
				string license = String.Empty;

				if ((font.License & LicenseType.Free) == LicenseType.Free)
				{
					license = "LicenseType.Free";
				}

				if ((font.License & LicenseType.Pro) == LicenseType.Pro)
				{
					if (!String.IsNullOrEmpty(license))
					{
						license = $"LicenseType.Pro | {license}";
					}
					else
					{
						license = "LicenseType.Pro";
					}
				}

				string freeStyles = String.Join(", ", font.FreeStyles.Select(t => $"\"{t}\""));
				string proStyles = String.Join(", ", font.ProStyles.Select(t => $"\"{t}\""));

				code.Append("\t\t/// <summary>\r\n");
				code.Append($"\t\t/// Gets the icon with id = {font.Id}.\r\n");
				code.Append("\t\t/// </summary>\r\n");
				code.Append($"\t\tpublic static FaIcon {font.ClassName} = new FaIcon(\"{font.Id}\", {font.Unicode}, true, \"{font.ClassName}\", {license}, new string[] {{ {freeStyles} }}, new string[] {{ {proStyles} }});");

				if (!font.Equals(fonts.Last()))
				{
					code.Append("\r\n\r\n");
				}
			}

			//
			// Update the code template.
			//
			templateCode = templateCode.Replace("//[%CODE%]", code.ToString());

			//
			// Write the output file.
			//
			File.WriteAllText(targetPath, templateCode);

			return source;
		}

		public static (IDictionary<string, Font> Fonts, FileInfo TemplateName) GenerateIconsSetClass(this (IDictionary<string, Font> Fonts, FileInfo Template) source, string version)
		{
			StringBuilder code = new StringBuilder();

			//
			// Create the target path.
			//
			string targetPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}\{source.Template.Name}";

			//
			// Read the template.
			//
			string templateCode = File.ReadAllText(source.Template.FullName);

			//
			// Generate the source code.
			//
			var fonts = source.Fonts.Select(t => t.Value).OrderBy(t => t.Id);
			foreach (Font font in fonts)
			{
				code.Append($"\t\t\t{{ FaIcons.{font.ClassName}.Id, FaIcons.{font.ClassName} }}");

				if (!font.Equals(fonts.Last()))
				{
					code.Append(",\r\n");
				}
			}

			//
			// Update the code template.
			//
			templateCode = templateCode.Replace("//[%CODE%]", code.ToString()).Replace("[%VERSION%]", version);

			//
			// Write the output file.
			//
			File.WriteAllText(targetPath, templateCode);

			return source;
		}
	}
}

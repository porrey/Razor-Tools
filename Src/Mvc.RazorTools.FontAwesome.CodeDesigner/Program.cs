using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Mvc.RazorTools.FontAwesome.CodeDesigner
{
	class Program
	{
		static void Main(string[] args)
		{
			Program program = new Program();
			program.Process();
		}

		public void Process()
		{
			// ***
			// *** Read the code template
			// ***
			//string definitionsTemplate = Properties.Resources.CodeTemplate;
			//string unitTestTemplate = Properties.Resources.UnitTestTemplate;
			//string unitTestClassTemplate = Properties.Resources.UnitTestClassTemplate;

			IDictionary<string, Font> fonts = new Dictionary<string, Font>();

			DirectoryInfo directoryInfo = new DirectoryInfo("Data");
			FileInfo[] files = directoryInfo.GetFiles();

			foreach (FileInfo file in files)
			{
				// ***
				// *** Read the json file.
				// ***
				string json = File.ReadAllText(file.FullName);

				// ***
				// *** Parse the json.
				// ***
				JArray jarray = JsonConvert.DeserializeObject<JArray>(json);

				// ***
				// *** Get the data array (list of font icons)
				// ***
				JToken items = jarray[2]["data"];

				foreach (JToken item in items)
				{
					// ***
					// *** Get the ID.
					// ***
					string id = item["id"].Value<string>();

					// ***
					// *** Get the membership (free or pro).
					// ***
					JToken membership = item["attributes"]["membership"];

					// ***
					// *** get the Unicode for the font.
					// ***
					string hexcode = item["attributes"]["unicode"].Value<string>();
					int unicode = Int32.Parse(hexcode, NumberStyles.HexNumber);

					// ***
					// *** Get the styles for this font icon that are free.
					// ***
					string[] freeStyles = (from tbl in (membership["free"] as JArray)
										   select tbl.Value<string>()).ToArray();

					if (freeStyles.Count() > 0)
					{
						// ***
						// ***
						// ***
						_ = this.AddUpdateFont(fonts, id, LicenseType.Free, hexcode, unicode, freeStyles);
					}

					// ***
					// *** Get the styles for this font icon that are part of the pro edition.
					// ***
					string[] proStyles = (from tbl in (membership["pro"] as JArray)
										  select tbl.Value<string>()).ToArray();

					if (proStyles.Count() > 0)
					{
						// ***
						// ***
						// ***
						_ = this.AddUpdateFont(fonts, id, LicenseType.Pro, hexcode, unicode, proStyles);
					}
				}
			}

			StringBuilder code = new StringBuilder();

			code.Append("namespace Mvc.RazorTools.FontAwesome\r\n");
			code.Append("{\r\n");
			code.Append("\t/// <summary>\r\n");
			code.Append("\t/// Definition of all icons.\r\n");
			code.Append("\t/// </summary>\r\n");
			code.Append("\tpublic class FontAwesomeIcons\r\n");
			code.Append("\t{\r\n");

			foreach (Font font in fonts.Select(t => t.Value))
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
				code.Append($"\t\tpublic static FontAwesomeIcon {font.ClassName} = new FontAwesomeIcon(\"{font.Id}\", {font.Unicode}, true, \"{font.ClassName}\", {license}, new string[] {{ {freeStyles} }}, new string[] {{ {proStyles} }});\r\n");
				code.Append("\r\n");
			}

			code.Append("\t}\r\n");
			code.Append("}\r\n");
			string s1 = code.ToString();

			code.Clear();
			foreach (Font font in fonts.Select(t => t.Value))
			{
				code.Append($"{{ FontAwesomeIcons.{font.ClassName}.Id, FontAwesomeIcons.{font.ClassName} }},\r\n");
			}

			s1 = code.ToString();
			code.Clear();
		}

		protected Font AddUpdateFont(IDictionary<string, Font> fonts, string id, LicenseType license, string hexcode, int unicode, IList<string> styles)
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
					ClassName = this.ConvertId(id)
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

		public string ConvertId(string id)
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
	}
}

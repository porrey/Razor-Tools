//
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
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Mvc.RazorTools.FontAwesome.CodeDesigner;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Mvc.RazorTools.FontAwesome.CodeDesigner
{
	class Program
	{
		static async Task Main(string[] args)
		{
			Program program = new Program();
			await program.Process(@".\Data");
		}

		public async Task Process(string sourceDirectory)
		{
			string currentVersion = await this.GetVersion();

			sourceDirectory.WithDirectory()
							.ReadFiles()
							.BuildFontDictionary()
							.WithTemplate(@".\Templates\FaIcons.cs").GenerateIconsClass()
							.WithTemplate(@".\Templates\FaIconSet.cs").GenerateIconsSetClass(currentVersion);
		}

		public async Task<string> GetVersion()
		{
			string returnValue = String.Empty;

			using (HttpClient client = new HttpClient())
			{
				object requestObject = new { query = "query { release(version: \"latest\") { version } }" };
				string requestJson = JsonConvert.SerializeObject(requestObject);

				using (StringContent content = new StringContent(requestJson, Encoding.UTF8, "application/json"))
				{
					using (var response = await client.PutAsync("https://api.fontawesome.com", content))
					{
						string json = await response.Content.ReadAsStringAsync();

						if (response.IsSuccessStatusCode)
						{
							JObject obj = JsonConvert.DeserializeObject<JObject>(json);
							returnValue = obj["data"]["release"]["version"].Value<string>();
						}
					}
				}
			}

			return returnValue;
		}
	}
}

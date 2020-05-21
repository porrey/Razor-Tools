using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4_Delete;
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

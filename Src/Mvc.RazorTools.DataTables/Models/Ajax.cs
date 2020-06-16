using Newtonsoft.Json;

namespace Mvc.RazorTools.DataTables
{
	public class Ajax
	{
		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; } = MethodTypes.Post;
	}
}

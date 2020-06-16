using Newtonsoft.Json;

namespace Mvc.RazorTools.DataTables
{
	public class DataTableRequest
	{
		[JsonProperty("draw")]
		public int Draw { get; set; }

		[JsonProperty("start")]
		public int Start { get; set; }

		[JsonProperty("length")]
		public int Length { get; set; }

		[JsonProperty("search")]
		public Search Search { get; set; }

		[JsonProperty("order")]
		public Order[] Order { get; set; }

		[JsonProperty("columns")]
		public Column[] Columns { get; set; }
	}
}

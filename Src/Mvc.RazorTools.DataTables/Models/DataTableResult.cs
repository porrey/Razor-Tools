using Newtonsoft.Json;

namespace Mvc.RazorTools.DataTables
{
	public class DataTableResult<TRow>
	{
		[JsonProperty("data")]
		public TRow[] Data { get; set; }

		[JsonProperty("draw")]
		public int Draw { get; set; }

		[JsonProperty("recordsFiltered")]
		public int RecordsFiltered { get; set; }

		[JsonProperty("recordsTotal")]
		public int RecordsTotal { get; set; }

		[JsonProperty("error")]
		public string Error { get; set; }
	}
}

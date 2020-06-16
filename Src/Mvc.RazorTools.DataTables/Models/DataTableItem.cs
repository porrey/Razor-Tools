using Newtonsoft.Json;

namespace Mvc.RazorTools.DataTables
{
	public class DataTableItem<TRow>
	{
		[JsonProperty(PropertyName = "DT_RowId")]
		public string RowId { get; set; }

		[JsonProperty(PropertyName = "DT_RowData")]
		public TRow RowData { get; set; }

		[JsonProperty(PropertyName = "DT_RowClass")]
		public string RowClass { get; set; }

		[JsonProperty(PropertyName = "DT_RowAttr")]
		public object RowAttributes { get; set; }
	}

	public class DataTableItem : DataTableItem<object>
	{
	}
}

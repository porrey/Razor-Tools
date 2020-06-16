using Newtonsoft.Json;

namespace Mvc.RazorTools.DataTables
{
	/// <summary>
	/// All strings that DataTables uses in its user interface are defined in this object,
	/// allowing you to modified them individually or completely replace them all as required.
	/// This ensures that DataTables is fully internationalizable as strings for any language
	/// can be used.
	/// </summary>
	public class Language
	{
		/// <summary>
		/// When using Ajax sourced data and during the first draw when DataTables is gathering
		/// the data, this message is shown in an empty row in the table to indicate to the end
		/// user the data is being loaded. Note that this parameter is not used when loading
		/// data by server-side processing, just Ajax sourced data with client-side processing.
		/// </summary>
		[JsonProperty("loadingRecords")]
		public string LoadingRecords { get; set; }

		/// <summary>
		/// Text that is displayed when the table is processing a user action (usually a
		/// sort command or similar).
		/// </summary>
		[JsonProperty("processing")]
		public string Processing { get; set; }
	}
}

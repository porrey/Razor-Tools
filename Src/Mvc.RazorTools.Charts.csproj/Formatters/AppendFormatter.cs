namespace Mvc.RazorTools.Charts
{
	/// <summary>
	/// A formatter for appending data to a string.
	/// </summary>
	public class AppendFormatter : CallbackFormatter
	{
		/// <summary>
		/// Creates an instance of a <see cref="AppendFormatter"/>
		/// with the specified format string.
		/// </summary>
		/// <param name="formatString">A string that represents the text to be added after the display value.</param>
		public AppendFormatter(string formatString)
			: base("Append")
		{
			this.FormatString = formatString;
		}
	}
}

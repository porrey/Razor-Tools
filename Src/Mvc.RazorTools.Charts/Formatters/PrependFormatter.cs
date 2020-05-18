namespace Mvc.RazorTools.Charts
{
	/// <summary>
	/// A formatter for perpending data to a string.
	/// </summary>
	public class PrependFormatter : CallbackFormatter
	{
		/// <summary>
		/// Creates an instance of a <see cref="PrependFormatter"/>
		/// with the specified format string.
		/// </summary>
		/// <param name="formatString">A string that represents the text to be added before the display value.</param>
		public PrependFormatter(string formatString)
			: base("prepend")
		{
			this.FormatString = formatString;
		}
	}
}

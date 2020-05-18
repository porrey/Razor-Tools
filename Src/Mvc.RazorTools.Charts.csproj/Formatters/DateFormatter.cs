namespace Mvc.RazorTools.Charts
{
	/// <summary>
	/// This formatter uses moment.js to format dates and times. use
	/// the moment.js syntax in the FormatString.
	/// </summary>
	public class DateFormatter : CallbackFormatter
	{
		/// <summary>
		/// Creates an instance of a <see cref="DateFormatter"/>
		/// with the specified format string.
		/// </summary>
		/// <param name="formatString">A format string representing how the date/time should be displayed. This formatter
		/// uses Moment.js for formatting date time values.</param>
		public DateFormatter(string formatString)
			: base("Date")
		{
			this.FormatString = formatString;
		}
	}
}

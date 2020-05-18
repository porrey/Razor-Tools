namespace Mvc.RazorTools.Charts
{
	/// <summary>
	/// A formatter for formatting percentages.
	/// </summary>
	public class PercentFormatter : CallbackFormatter
	{
		/// <summary>
		/// Creates an instance of a <see cref="PercentFormatter"/>
		/// with the specified number of decimal places.
		/// </summary>
		/// <param name="decimalPlaces">The number of decimal places to display.</param>
		public PercentFormatter(int decimalPlaces)
			: base("Percent")
		{
			this.FormatString = decimalPlaces.ToString();
		}
	}
}

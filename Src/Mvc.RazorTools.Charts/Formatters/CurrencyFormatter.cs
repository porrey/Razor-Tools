namespace Mvc.RazorTools.Charts
{
	/// <summary>
	/// A formatter for formatting currency.
	/// </summary>
	public class CurrencyFormatter : CallbackFormatter
	{
		/// <summary>
		/// Creates an instance of a <see cref="CurrencyFormatter"/>
		/// with the specified number of decimal places.
		/// </summary>
		/// <param name="decimalPlaces">The number of decimal places to display.</param>
		public CurrencyFormatter(int decimalPlaces)
			: base("Currency")
		{
			this.FormatString = decimalPlaces.ToString();
		}
	}
}

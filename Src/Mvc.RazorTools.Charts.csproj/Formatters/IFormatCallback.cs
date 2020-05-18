namespace Mvc.RazorTools.Charts
{
	/// <summary>
	/// Interface specification for a callback formatter used by the
	/// JavaScript library for formatting display values.
	/// </summary>
	public interface IFormatCallback
	{
		/// <summary>
		/// Gets/sets the string used for formatting the display.
		/// </summary>
		string FormatString { get; set; }

		/// <summary>
		/// Gets the unique string name representing the type
		/// of formatter.
		/// </summary>
		string Type { get; }

		/// <summary>
		/// Gets the attribute value written in the HTML tag for
		/// this formatter.
		/// </summary>
		string AttributeValue { get; }
	}
}

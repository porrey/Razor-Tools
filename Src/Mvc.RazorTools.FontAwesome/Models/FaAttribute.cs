namespace Mvc.RazorTools.FontAwesome
{
	/// <summary>
	/// Represents a size to apply to a FontAwesome icon.
	/// </summary>
	public abstract class FaAttribute
	{
		/// <summary>
		/// Gets/sets the name of the size.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets/sets the class attribute used in the HTML tag.
		/// </summary>
		public string ClassAttribute { get; set; }
	}
}

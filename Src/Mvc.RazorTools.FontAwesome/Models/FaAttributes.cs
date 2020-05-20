namespace Mvc.RazorTools.FontAwesome
{
	/// <summary>
	/// Contains a set of predefined class attributes for the Font Awesome
	/// icons. The items are defined on the Font Awesome web site and are
	/// intended to modify the existing icons in some way. For example, some
	/// attributes will rotate the icon, spin it or alter the default size.
	/// </summary>
	public static class FaAttributes
	{
		/// <summary>
		/// 
		/// </summary>
		public static FaAttribute Border = new FaAttribute()
		{
			Name = "Border",
			ClassAttribute = "fa-border"
		};

		/// <summary>
		/// 
		/// </summary>
		public static FaAttribute FixedWidth = new FaAttribute()
		{
			Name = "FixedWidth",
			ClassAttribute = "fa-fw"
		};

		/// <summary>
		/// 
		/// </summary>
		public static FaAttribute Inverse = new FaAttribute()
		{
			Name = "Inverse",
			ClassAttribute = "fa-inverse"
		};

		/// <summary>
		/// 
		/// </summary>
		public static FaAttribute PullRight = new FaAttribute()
		{
			Name = "PullRight",
			ClassAttribute = "fa-pull-right"
		};

		/// <summary>
		/// 
		/// </summary>
		public static FaAttribute PullLeft = new FaAttribute()
		{
			Name = "PullLeft",
			ClassAttribute = "fa-pull-left"
		};

		/// <summary>
		/// 
		/// </summary>
		public static FaAttribute SwapOpacity = new FaAttribute()
		{
			Name = "SwapOpacity",
			ClassAttribute = "fa-swap-opacity"
		};

		/// <summary>
		/// 
		/// </summary>
		public const string Ul = "fa-ul";

		/// <summary>
		/// 
		/// </summary>
		public const string Li = "fa-li";
	}
}

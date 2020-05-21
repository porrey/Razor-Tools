namespace Mvc.RazorTools.FontAwesome
{
	/// <summary>
	/// Defines the possible styles to use with a FontAwesome icon.
	/// </summary>
	public static class FaStyles
	{
		/// <summary>
		/// The icon is to be displayed with the Solid style.
		/// </summary>
		public static FaStyle Solid = new FaStyle()
		{
			Name = "Solid",
			ClassAttribute = "fas"
		};

		/// <summary>
		/// The icon is to be displayed with the Regular style.
		/// </summary>
		public static FaStyle Regular = new FaStyle()
		{
			Name = "Regular",
			ClassAttribute = "far"
		};

		/// <summary>
		/// The icon is to be displayed with the Light style.
		/// </summary>
		public static FaStyle Light = new FaStyle()
		{
			Name = "Light",
			ClassAttribute = "fal"
		};

		/// <summary>
		/// The icon is to be displayed with the Duotone style.
		/// </summary>
		public static FaStyle Duotone = new FaStyle()
		{
			Name = "Duotone",
			ClassAttribute = "fad"
		};
	}
}

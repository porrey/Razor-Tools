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
		public static FaqStyle Solid = new FaqStyle()
		{
			Name = "Solid",
			ClassAttribute = "fas"
		};

		/// <summary>
		/// The icon is to be displayed with the Regular style.
		/// </summary>
		public static FaqStyle Regular = new FaqStyle()
		{
			Name = "Regular",
			ClassAttribute = "far"
		};

		/// <summary>
		/// The icon is to be displayed with the Light style.
		/// </summary>
		public static FaqStyle Light = new FaqStyle()
		{
			Name = "Light",
			ClassAttribute = "fal"
		};

		/// <summary>
		/// The icon is to be displayed with the Duotone style.
		/// </summary>
		public static FaqStyle Duotone = new FaqStyle()
		{
			Name = "Duotone",
			ClassAttribute = "fad"
		};
	}
}

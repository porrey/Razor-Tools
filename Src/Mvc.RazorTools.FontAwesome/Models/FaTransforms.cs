namespace Mvc.RazorTools.FontAwesome
{
	/// <summary>
	/// Contains a set of predefined class attributes for the Font Awesome
	/// icons. The items are defined on the Font Awesome web site and are
	/// intended to modify the existing icons in some way. For example, some
	/// attributes will rotate the icon, spin it or alter the default size.
	/// </summary>
	public static class FaTransforms
	{
		/// <summary>
		/// 
		/// </summary>
		public static FaTransform Spin = new FaTransform()
		{
			Name = "Spin",
			ClassAttribute = "fa-spin"
		};

		/// <summary>
		/// 
		/// </summary>
		public static FaTransform Pulse = new FaTransform()
		{
			Name = "Pulse",
			ClassAttribute = "fa-pulse"
		};

		/// <summary>
		/// 
		/// </summary>
		public static FaTransform Rotate90 = new FaTransform()
		{
			Name = "Rotate90",
			ClassAttribute = "fa-rotate-90"
		};

		/// <summary>
		/// 
		/// </summary>
		public static FaTransform Rotate180 = new FaTransform()
		{
			Name = "Rotate180",
			ClassAttribute = "fa-rotate-180"
		};

		/// <summary>
		/// 
		/// </summary>
		public static FaTransform Rotate270 = new FaTransform()
		{
			Name = "Rotate270",
			ClassAttribute = "fa-rotate-270"
		};

		/// <summary>
		/// 
		/// </summary>
		public static FaTransform FlipHorizontal = new FaTransform()
		{
			Name = "FlipHorizontal",
			ClassAttribute = "fa-flip-horizontal"
		};

		/// <summary>
		/// 
		/// </summary>
		public static FaTransform FlipVertical = new FaTransform()
		{
			Name = "FlipVertical",
			ClassAttribute = "fa-flip-vertical"
		};

		/// <summary>
		/// 
		/// </summary>
		public static FaTransform Both = new FaTransform()
		{
			Name = "Both",
			ClassAttribute = "fa-flip-both"
		};
	}
}

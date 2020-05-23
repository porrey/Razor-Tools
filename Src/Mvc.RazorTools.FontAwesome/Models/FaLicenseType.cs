using System;

namespace Mvc.RazorTools.FontAwesome
{
	/// <summary>
	/// Defines the license required to use a specific icon.
	/// </summary>
	[Flags]
	public enum FaLicenseType
	{
		/// <summary>
		/// The license type has not been specified.
		/// </summary>
		None = 0,
		/// <summary>
		/// Specifies that an icon can be used with a free license.
		/// </summary>
		Free = 1,
		/// <summary>
		/// Specifies that an icon requires the pro license.
		/// </summary>
		Pro = 2
	}
}
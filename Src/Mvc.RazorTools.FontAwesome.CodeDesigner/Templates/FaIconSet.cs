using System.Collections.Generic;
using System.Linq;

namespace Mvc.RazorTools.FontAwesome
{
	/// <summary>
	/// Includes the known icons in the Font Awesome set for version [%VERSION%];
	/// </summary>
	public class FaIconSet
	{
		/// <summary>
		/// Gets the version of Font Awesome that this library is based on.
		/// </summary>
		public static string Version => "[%VERSION%]";

		/// <summary>
		/// Gets the number of icons defined in the current version of Font Awesome. Note this number
		/// will be greater than the count shown on the FontAwesome web site due to the icons that are
		/// aliased.
		/// </summary>
		public static int IconCount => AllItems.Count();

		/// <summary>
		/// Gets a Dictionary of predefined icons by class name. This dictionary
		/// allows querying of the icons using LINQ.
		/// </summary>
		public static Dictionary<string, FaIcon> AllItems { get; } = new Dictionary<string, FaIcon>
		{
//[%CODE%]
		};
	}
}
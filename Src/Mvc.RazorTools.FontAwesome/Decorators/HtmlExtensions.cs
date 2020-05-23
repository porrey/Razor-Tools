using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Mvc.RazorTools.FontAwesome
{
	/// <summary>
	/// Provides a set of extension methods for the <see cref="IHtmlHelper"/>. These extension
	/// methods are referenced in the razor view using the @Html keyword.
	/// </summary>
	public static class HtmlExtensions
	{
		/// <summary>
		/// All of the icons in <see cref="FaIcons"/> are locked and can be modified. This method creates
		/// a copy of the specified icon that can be styled and modified in a Razor view/page.
		/// </summary>
		/// <param name="item">The <see cref="FaIcon"/> instance that is being created.</param>
		/// <returns>Returns an instance of <see cref="FaIcon"/> that can be styled and modified.</returns>
		public static FaIcon Create([NotNull]this FaIcon item)
		{
			return (FaIcon)item.Clone();
		}
	}
}

using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Html;
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
		/// 
		/// </summary>
		/// <param name="html"></param>
		/// <param name="item"></param>
		/// <returns></returns>
		public static IHtmlContent Fa([NotNull]this IHtmlHelper html, FaIcon item)
		{
			return item.Html;
		}
	}
}

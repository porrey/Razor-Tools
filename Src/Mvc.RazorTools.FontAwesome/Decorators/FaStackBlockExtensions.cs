using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Mvc.RazorTools.FontAwesome
{
	/// <summary>
	/// Extensions methods for Mvc.RazorTools.FontAwesome.FontAwesomeStackHtml
	/// </summary>
	public static class FaStackBlockExtensions
	{
		/// <summary>
		/// Creates an instance of <see cref="FaStackBlock"/> with the
		/// specified <see cref="IHtmlHelper"/> object. Intended to be wrapped in a
		/// using statement inside of a Razor View.
		/// </summary>
		/// <param name="html">An instance of <see cref="IHtmlHelper"/>.</param>
		/// <returns>An instance of <see cref="FaStackBlock"/>.</returns>
		public static FaStackBlock BeginFontAaStack([NotNull]this IHtmlHelper html)
		{
			return new FaStackBlock(html);
		}

		/// <summary>
		/// Creates an instance of <see cref="FaStackBlock"/> with the
		/// specified <see cref="IHtmlHelper"/> object and style. Intended to be wrapped in a
		/// using statement inside of a Razor View.
		/// </summary>
		/// <param name="html">An instance of <see cref="IHtmlHelper"/>.</param>
		/// <param name="attribute">A <see cref="FaStackAttribute"/> attribute to apply.</param>
		/// <returns>An instance of <see cref="FaStackBlock"/>.</returns>
		public static FaStackBlock BeginFaStack([NotNull]this IHtmlHelper html, [NotNull]FaAttribute attribute)
		{
			return new FaStackBlock(html, attribute.ClassAttribute);
		}
	}
}

using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Mvc.RazorTools.FontAwesome
{
	/// <summary>
	/// Allows the creating of a Font Awesome Stack using syntax similar to
	/// BeginForm.
	/// </summary>
	public class FontAwesomeStackHtml : IDisposable
	{
		private IHtmlHelper _html = null;

		/// <summary>
		/// Creates an instance of <see cref="FontAwesomeStackHtml"/> with the
		/// specified <see cref="IHtmlHelper"/> object.
		/// </summary>
		/// <param name="html">An instance of <see cref="IHtmlHelper"/>.</param>
		public FontAwesomeStackHtml(IHtmlHelper html)
		{
			_html = html;
			_html.ViewContext.Writer.WriteLine("<span class=\"{0}\">", FontAwesomeStyles.Stack);
		}

		/// <summary>
		/// Creates an instance of <see cref="FontAwesomeStackHtml"/> with the
		/// specified <see cref="IHtmlHelper"/> object and style.
		/// </summary>
		/// <param name="html">An instance of <see cref="IHtmlHelper"/>.</param>
		/// <param name="style">A CSS style to be applied to the Span tag.</param>
		public FontAwesomeStackHtml(IHtmlHelper html, string style)
		{
			_html = html;
			_html.ViewContext.Writer.WriteLine("<span class=\"{0} {1}\">", FontAwesomeStyles.Stack, style);
		}

		/// <summary>
		/// Disposes this instance causing the remaining HTML to be
		/// written to the ViewContext.
		/// </summary>
		public void Dispose()
		{
			if (_html != null)
			{
				_html.ViewContext.Writer.WriteLine("</span>");
				_html = null;
			}
		}
	}

	/// <summary>
	/// Extensions methods for Mvc.RazorTools.FontAwesome.FontAwesomeStackHtml
	/// </summary>
	public static class FontAwesomeStackHtmlExtensions
	{
		/// <summary>
		/// Creates an instance of <see cref="FontAwesomeStackHtml"/> with the
		/// specified <see cref="IHtmlHelper"/> object. Intended to be wrapped in a
		/// using statement inside of a Razor View.
		/// </summary>
		/// <param name="html">An instance of <see cref="IHtmlHelper"/>.</param>
		/// <returns>An instance of <see cref="FontAwesomeStackHtml"/>.</returns>
		public static FontAwesomeStackHtml BeginFontAwesomeStack(this HtmlHelper html)
		{
			return new FontAwesomeStackHtml(html);
		}

		/// <summary>
		/// Creates an instance of <see cref="FontAwesomeStackHtml"/> with the
		/// specified <see cref="IHtmlHelper"/> object and style. Intended to be wrapped in a
		/// using statement inside of a Razor View.
		/// </summary>
		/// <param name="html">An instance of <see cref="IHtmlHelper"/>.</param>
		/// <param name="style">A CSS style to be applied to the Span tag.</param>
		/// <returns>An instance of <see cref="FontAwesomeStackHtml"/>.</returns>
		public static FontAwesomeStackHtml BeginFontAwesomeStack(this HtmlHelper html, string style)
		{
			return new FontAwesomeStackHtml(html, style);
		}
	}
}

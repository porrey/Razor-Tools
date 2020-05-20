using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Mvc.RazorTools.FontAwesome
{
	/// <summary>
	/// Allows the creating of a Font Awesome Stack using syntax similar to
	/// BeginForm.
	/// </summary>
	public class FaStackBlock : IDisposable
	{
		/// <summary>
		/// Contains the tag information.
		/// </summary>
		protected IHtmlHelper Html { get; set; }

		/// <summary>
		/// Creates an instance of <see cref="FaStackBlock"/> with the
		/// specified <see cref="IHtmlHelper"/> object.
		/// </summary>
		/// <param name="html">An instance of <see cref="IHtmlHelper"/>.</param>
		public FaStackBlock(IHtmlHelper html)
		{
			this.Html = html;
			this.Html.ViewContext.Writer.WriteLine("<span class=\"{0}\">", FaStackAttributes.Stack.ClassAttribute);
		}

		/// <summary>
		/// Creates an instance of <see cref="FaStackBlock"/> with the
		/// specified <see cref="IHtmlHelper"/> object and style.
		/// </summary>
		/// <param name="html">An instance of <see cref="IHtmlHelper"/>.</param>
		/// <param name="style">A CSS style to be applied to the Span tag.</param>
		public FaStackBlock(IHtmlHelper html, string style)
		{
			this.Html = html;
			this.Html.ViewContext.Writer.WriteLine("<span class=\"{0} {1}\">", FaStackAttributes.Stack.ClassAttribute, style);
		}

		/// <summary>
		/// Disposes this instance causing the remaining HTML to be
		/// written to the <see cref="ViewContext"/>.
		/// </summary>
		public void Dispose()
		{
			if (this.Html != null)
			{
				this.Html.ViewContext.Writer.WriteLine("</span>");
				this.Html = null;
			}
		}
	}
}

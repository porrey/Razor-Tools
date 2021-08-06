//
// Copyright(C) 2014-2020, Daniel M. Porrey. All rights reserved.
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published
// by the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program. If not, see http://www.gnu.org/licenses/.
//
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

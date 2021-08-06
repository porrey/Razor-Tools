//
// Copyright(C) 2014-2021, Daniel M. Porrey. All rights reserved.
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
		public static FaStackBlock BeginFaStack([NotNull]this IHtmlHelper html)
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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="html"></param>
		/// <param name="attributes"></param>
		/// <returns></returns>
		public static FaStackBlock BeginFaStack([NotNull]this IHtmlHelper html, [NotNull]params FaAttribute[] attributes)
		{
			FaStackBlock returnValue = new FaStackBlock(html);

			foreach (FaAttribute attribute in attributes)
			{
				
			}

			return returnValue;
		}
	}
}

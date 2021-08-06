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

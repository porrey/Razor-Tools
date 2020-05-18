// ***
// *** Copyright(C) 2014-2020, Daniel M. Porrey. All rights reserved.
// *** 
// *** This program is free software: you can redistribute it and/or modify
// *** it under the terms of the GNU Lesser General Public License as published
// *** by the Free Software Foundation, either version 3 of the License, or
// *** (at your option) any later version.
// *** 
// *** This program is distributed in the hope that it will be useful,
// *** but WITHOUT ANY WARRANTY; without even the implied warranty of
// *** MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// *** GNU Lesser General Public License for more details.
// *** 
// *** You should have received a copy of the GNU Lesser General Public License
// *** along with this program. If not, see http://www.gnu.org/licenses/.
// ***
using System;
using Microsoft.AspNetCore.Html;

namespace Mvc.RazorTools
{
	/// <summary>
	/// Provides the basic methods for an HTML tag object in this library
	/// including basic operations to add custom class attributes.
	/// </summary>
	public interface IMvcRazorObject : IMvcRazorAttributes, IMvcRazorStyles, IMvcRazorClassAttributes, ICloneable
	{
		/// <summary>
		/// Gets/sets the HTML node ID for this object. Read-only if this implementation is locked.
		/// </summary>
		string Id { get; set; }

		/// <summary>
		/// Gets/sets the name of this implementation. This value is for display or managing
		/// purposes only and is not used internally by this library. Read-only if 
		/// this implementation is locked.
		/// </summary>
		string Name { get; set; }

		/// <summary>
		/// Gets/sets the default HTML parent tag that will be generated from this
		/// MVC Razor Object.
		/// </summary>
		string HtmlTag { get; set; }

		/// <summary>
		/// Gets/sets value that indicates of this implementation is locked. Once locked,
		/// the implementation cannot be unlocked.
		/// </summary>
		bool Locked { get; set; }

		/// <summary>
		/// Gets the MvcHtmlString containing the HTML markup of this implementation.
		/// </summary>
		IHtmlContent Html { get; }

		/// <summary>
		/// Gets/sets value that determines if the element Id tag is included in the
		/// Class Attributes HTL.
		/// </summary>
		bool IncludeIdInHtml { get; set; }
	}
}

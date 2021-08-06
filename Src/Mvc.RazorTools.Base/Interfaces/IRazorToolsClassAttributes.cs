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
using System.Collections.Generic;

namespace Mvc.RazorTools
{
	/// <summary>
	/// The class attributes added when the HTML tag is rendered.
	/// </summary>
	public interface IRazorToolsClassAttributes
	{
		/// <summary>
		/// Gets the set of class attributes used when formatting the HTML tag.
		/// </summary>
		IList<string> ClassAttributes { get; }

		/// <summary>
		/// Add a custom class attribute to the set contained within this implementation. The
		/// key and the value will contain the value of 'item'. Item is the value that 
		/// will be used when formatting the HTML class attribute.
		/// </summary>
		/// <param name="item">A <see cref="String"/> value containing the attribute to be included in the HTML markup.</param>
		void AddClassAttribute(string item);

		/// <summary>
		/// Merges a set of class attributes with the current items.
		/// </summary>
		/// <param name="items">A list of attribute values to be merged
		/// into the current set in this implementation.</param>
		void MergeClassAttributes(IEnumerable<string> items);
	}
}

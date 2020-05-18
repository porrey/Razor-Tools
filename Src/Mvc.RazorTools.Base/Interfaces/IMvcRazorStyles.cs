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
using System.Collections.Generic;

namespace Mvc.RazorTools
{
	/// <summary>
	/// The styles added when the HTML tag is rendered.
	/// </summary>
	public interface IMvcRazorStyles
	{
		/// <summary>
		/// Gets a list of styles added when formatting the HTML markup.
		/// </summary>
		IDictionary<string, string> Styles { get; }

		/// <summary>
		/// Add a style to the set contained within this instance when formatting the HTML markup.
		/// </summary>
		/// <param name="name">A System.String representing the style name.</param>
		/// <param name="value">A System.String representing the style value..</param>
		void AddStyle(string name, string value);

		/// <summary>
		/// Merges a set of styles with the current items.
		/// </summary>
		/// <param name="items">A list of style names and values to be merged
		/// into the current set in this instance.</param>
		void MergeStyles(IDictionary<string, string> items);

		/// <summary>
		/// Update an exiting style contained in this instance. If the value exists 
		/// it will be replaced otherwise it will added to the list.
		/// </summary>
		/// <param name="name">A System.String representing the style name.</param>
		/// <param name="value">A System.String representing the style value.</param>
		void UpdateStyle(string name, string value);
	}
}

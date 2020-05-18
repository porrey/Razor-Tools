using System;
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

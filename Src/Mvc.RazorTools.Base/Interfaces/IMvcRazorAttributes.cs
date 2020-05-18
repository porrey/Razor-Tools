using System;
using System.Collections.Generic;

namespace Mvc.RazorTools
{
	/// <summary>
	/// The attributes added when the HTML tag is rendered.
	/// </summary>
	public interface IMvcRazorAttributes
	{
		/// <summary>
		/// Gets a list of attributes added when formatting the HTML markup.
		/// </summary>
		IDictionary<string, string> Attributes { get; }

		/// <summary>
		/// Add an attribute to the set contained within this instance when formatting the HTML markup.
		/// </summary>
		/// <param name="name">A System.String representing the attribute name.</param>
		/// <param name="value">A System.String value containing the attribute to be included in the HTML markup.</param>
		void AddAttribute(string name, string value);

		/// <summary>
		/// Merges a set of attributes with the current items.
		/// </summary>
		/// <param name="items">A list of attribute names and values to be merged
		/// into the current set in this instance.</param>
		void MergeAttributes(IDictionary<string, string> items);

		/// <summary>
		/// Update an exiting attribute contained in this instance. If the value exists 
		/// it will be replaced otherwise it will added to the list.
		/// </summary>
		/// <param name="name">A System.String representing the attribute name.</param>
		/// <param name="value">A System.String value containing the attribute to be included in the HTML markup.</param>
		void UpdateAttribute(string name, string value);
	}
}

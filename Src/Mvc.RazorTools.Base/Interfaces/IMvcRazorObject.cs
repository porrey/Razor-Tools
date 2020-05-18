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

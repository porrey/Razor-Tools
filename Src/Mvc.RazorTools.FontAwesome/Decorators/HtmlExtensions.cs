using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
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
		/// Inserts the specified FontAwesomeIcon into the view.
		/// </summary>
		/// <param name="html">The view's current <see cref="IHtmlHelper"/> instance.</param>
		/// <param name="item">The icon to be displayed. This can be a custom instance or one of the
		/// predefined icons in FontAwesomeIconSet (for example, to display the star icon use
		/// <see cref="FontAwesomeIconSet.Star"/>).</param>
		/// <param name="classAttributes">The custom attributes to be added to the icon.</param>
		/// <returns></returns>
		public static IHtmlContent FontAwesome(this IHtmlHelper html, FontAwesomeIcon item, params string[] classAttributes)
		{
			if (html == null)
			{
				throw new ArgumentNullException("html");
			}

			if (item == null)
			{
				throw new ArgumentNullException("item");
			}

			FontAwesomeIcon font = (FontAwesomeIcon)item.Clone();
			font.MergeClassAttributes(classAttributes);
			return font.Html;
		}

		/// <summary>
		/// Inserts the specified <see cref="FontAwesomeIcon"/> into the view.
		/// </summary>
		/// <param name="html">The view's current <see cref="IHtmlHelper"/> instance.</param>
		/// <param name="item">The CSS class name of the icon to be displayed (for example, to display the star icon
		/// use fas-star).</param>
		/// <param name="classAttributes">The custom attributes to be added to the icon.</param>
		/// <returns></returns>
		public static IHtmlContent FontAwesome(this IHtmlHelper html, string item, params string[] classAttributes)
		{
			if (html == null)
			{
				throw new ArgumentNullException("html");
			}

			if (String.IsNullOrEmpty(item))
			{
				throw new ArgumentNullException("item");
			}

			FontAwesomeIcon font = new FontAwesomeIcon(item);
			font.MergeClassAttributes(classAttributes);
			return font.Html;
		}

		/// <summary>
		/// Insert the specified icon stack into the view.
		/// </summary>
		/// <param name="html">The view's current <see cref="IHtmlHelper"/> instance.</param>
		/// <param name="stack">The stack instance to display.</param>
		/// <param name="classAttributes">The custom attributes to be added to the stack (not the icons).</param>
		/// <returns></returns>
		public static IHtmlContent FontAwesomeStack(this IHtmlHelper html, FontAwesomeStack stack, params string[] classAttributes)
		{
			if (html == null)
			{
				throw new ArgumentNullException("html");
			}

			if (stack == null)
			{
				throw new ArgumentNullException("stack");
			}

			stack.MergeClassAttributes(classAttributes);
			return stack.Html;
		}

		/// <summary>
		/// Insert the specified list of icons as a stack into the view.
		/// </summary>
		/// <param name="html">The view's current <see cref="IHtmlHelper"/> instance.</param>
		/// <param name="items">The list of icons to stack.</param>
		/// <param name="classAttributes">The custom attributes to be added to the stack (not the icons).</param>
		/// <returns></returns>
		public static IHtmlContent FontAwesomeStack(this IHtmlHelper html, IEnumerable<FontAwesomeIcon> items, params string[] classAttributes)
		{
			if (html == null)
			{
				throw new ArgumentNullException("html");
			}

			if (items == null)
			{
				throw new ArgumentNullException("items");
			}

			FontAwesomeStack stack = new FontAwesomeStack(items, classAttributes);
			return stack.Html;
		}

		/// <summary>
		/// Insert the specified list of icons as a stack into the view.
		/// </summary>
		/// <param name="html">The view's current <see cref="IHtmlHelper"/> instance.</param>
		/// <param name="items">The list of icons to stack.</param>
		/// <param name="classAttributes">The custom attributes to be added to the stack (not the icons).</param>
		/// <returns></returns>
		public static IHtmlContent FontAwesomeStack(this IHtmlHelper html, params FontAwesomeIcon[] items)
		{
			if (html == null)
			{
				throw new ArgumentNullException("html");
			}

			if (items == null)
			{
				throw new ArgumentNullException("items");
			}

			FontAwesomeStack stack = new FontAwesomeStack(items);
			return stack.Html;
		}
	}
}

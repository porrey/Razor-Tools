using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
		/// predefined icons in <see cref="FaIcons"/> (for example, to display the star icon use
		/// <see cref="FaIcons.Star"/>).</param>
		/// <param name="classAttributes">The custom attributes to be added to the icon.</param>
		/// <returns></returns>
		public static IHtmlContent FontAwesome([NotNull]this IHtmlHelper html, FaIcon item, params string[] classAttributes)
		{
			FaIcon font = (FaIcon)item.Clone();
			font.MergeClassAttributes(classAttributes);
			return font.Html;
		}

		/// <summary>
		/// Inserts the specified <see cref="FaIcon"/> into the view.
		/// </summary>
		/// <param name="html">The view's current <see cref="IHtmlHelper"/> instance.</param>
		/// <param name="item">The CSS class name of the icon to be displayed (for example, to display the star icon
		/// use fas-star).</param>
		/// <param name="classAttributes">The custom attributes to be added to the icon.</param>
		/// <returns></returns>
		public static IHtmlContent FontAwesome([NotNull]this IHtmlHelper html, [NotNull]string item, params string[] classAttributes)
		{
			FaIcon font = new FaIcon(item);
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
		public static IHtmlContent FontAwesomeStack([NotNull]this IHtmlHelper html, [NotNull]FaStack stack, params string[] classAttributes)
		{
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
		public static IHtmlContent FontAwesomeStack([NotNull]this IHtmlHelper html, [NotNull]IEnumerable<FaIcon> items, params string[] classAttributes)
		{
			FaStack stack = new FaStack(items, classAttributes);
			return stack.Html;
		}

		/// <summary>
		/// Insert the specified list of icons as a stack into the view.
		/// </summary>
		/// <param name="html">The view's current <see cref="IHtmlHelper"/> instance.</param>
		/// <param name="items">The list of icons to stack.</param>
		/// <returns></returns>
		public static IHtmlContent FontAwesomeStack([NotNull]this IHtmlHelper html, params FaIcon[] items)
		{
			FaStack stack = new FaStack(items);
			return stack.Html;
		}
	}
}

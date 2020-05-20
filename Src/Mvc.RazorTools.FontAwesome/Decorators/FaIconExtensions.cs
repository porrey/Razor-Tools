using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Mvc.RazorTools.FontAwesome
{
	/// <summary>
	/// Provides a set of extension methods for a <see cref="FaIcon"/>
	/// object to be used within the Razor view.
	/// </summary>
	public static class FaIconExtensions
	{
		internal static class Constants
		{
			public const string Space = " ";
		}

		/// <summary>
		/// Applies a style to the icon.
		/// </summary>
		/// <param name="icon">The icon the style is applied.</param>
		/// <param name="style">The <see cref="FaqStyle"/> that will be
		/// applied to the icon.</param>
		/// <returns>The updated icon.</returns>
		public static FaIcon WithStyle([NotNull]this FaIcon icon, [NotNull]FaqStyle style)
		{
			FaIcon returnValue = icon.Clone() as FaIcon;
			returnValue.AddClassAttribute(style.ClassAttribute);
			return returnValue;
		}

		/// <summary>
		/// Applies a resizing option to the icon.
		/// </summary>
		/// <param name="icon">The icon the style is applied.</param>
		/// <param name="size">An <see cref="FaSize"/> to increase or decrease the default size.</param>
		/// <returns></returns>
		public static FaIcon WithSize([NotNull]this FaIcon icon, [NotNull]FaSize size)
		{
			icon.AddClassAttribute(size.ClassAttribute);
			return icon;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="icon"></param>
		/// <param name="attribute"></param>
		/// <returns></returns>
		public static FaIcon WithAttribute([NotNull]this FaIcon icon, [NotNull]FaAttribute attribute)
		{
			icon.AddClassAttribute(attribute.ClassAttribute);
			return icon;
		}

		/// <summary>
		/// Add any custom class attribute to the icon.
		/// </summary>
		/// <param name="icon"></param>
		/// <param name="classAttribute"></param>
		/// <returns></returns>
		public static FaIcon WithClassAttribute([NotNull]this FaIcon icon, [NotNull]string classAttribute)
		{
			icon.AddClassAttribute(classAttribute);
			return icon;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="icon"></param>
		/// <param name="transform"></param>
		/// <returns></returns>
		public static FaIcon WithTransform([NotNull]this FaIcon icon, [NotNull]FaTransform transform)
		{
			icon.AddClassAttribute(transform.ClassAttribute);
			return icon;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="icon"></param>
		/// <param name="attribute"></param>
		/// <returns></returns>
		public static FaIcon WithStackAttribute([NotNull]this FaIcon icon, [NotNull]FaStackAttribute attribute)
		{
			icon.AddClassAttribute(attribute.ClassAttribute);
			return icon;
		}

		/// <summary>
		/// Gets the class attribute value only for the given FontAwesomeIcon instance.
		/// </summary>
		/// <param name="icon">The existing <see cref="FaIcon"/> to modify.</param>
		/// <returns>A <see cref="String"/> value containing the class attribute value from the HTML markup
		/// generated for this icon.</returns>
		public static string GetCssOnly(this FaIcon icon)
		{
			return icon.ClassAttributes.Values.Aggregate(string.Empty, (o, i) => o + Constants.Space + i).TrimStart();
		}
	}
}

﻿using System;
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
		/// <param name="style">The <see cref="FaStyle"/> that will be
		/// applied to the icon.</param>
		/// <returns>The updated icon.</returns>
		public static FaIcon WithStyle([NotNull]this FaIcon icon, [NotNull]FaStyle style)
		{
			FaIcon returnValue = icon.Clone() as FaIcon;
			returnValue.AddClassAttribute(style.ClassAttribute);
			return returnValue;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="icon"></param>
		/// <returns></returns>
		public static FaIcon AsBrand([NotNull]this FaIcon icon)
		{
			FaIcon returnValue = icon.Clone() as FaIcon;
			returnValue.AddClassAttribute("fab");
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
		/// <param name="option"></param>
		/// <returns></returns>
		public static FaIcon WithOption([NotNull]this FaIcon icon, [NotNull]FaOption option)
		{
			icon.AddClassAttribute(option.ClassAttribute);
			return icon;
		}

		/// <summary>
		/// Add any custom class attribute to the icon.
		/// </summary>
		/// <param name="icon"></param>
		/// <param name="classAttribute"></param>
		/// <returns></returns>
		public static FaIcon WithClass([NotNull]this FaIcon icon, [NotNull]string classAttribute)
		{
			icon.AddClassAttribute(classAttribute);
			return icon;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="icon"></param>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public static FaIcon WithCssStyle([NotNull]this FaIcon icon, [NotNull]string name, [NotNull]string value)
		{
			icon.AddStyle(name, value);
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
		public static string CssOnly(this FaIcon icon)
		{
			return icon.ClassAttributes.Values.Aggregate(String.Empty, (o, i) => o + Constants.Space + i).TrimStart();
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mvc.RazorTools.FontAwesome
{
	/// <summary>
	/// Provides a set of extension methods for a <see cref="FontAwesomeIcon"/>
	/// object to be used within the Razor view.
	/// </summary>
	public static class FontAwesomeIconExtensions
	{
		internal static class Constants
		{
			public const string Space = " ";
		}

		/// <summary>
		/// Customizes an existing <see cref="FontAwesomeIcon"/> by adding
		/// class attributes and returning the object. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="icon">The existing <see cref="FontAwesomeIcon"/> to modify.</param>
		/// <param name="items">The class attributes to be added to the existing instance.</param>
		/// <returns>A new modified instance of the <see cref="FontAwesomeIcon"/> object.</returns>
		public static FontAwesomeIcon Customize(this FontAwesomeIcon icon, params string[] items)
		{
			if (icon == null)
			{
				throw new ArgumentNullException("icon");
			}

			if (items == null)
			{
				throw new ArgumentNullException("items");
			}

			FontAwesomeIcon returnValue = icon.Clone() as FontAwesomeIcon;

			// ***
			// *** Make a copy of each class descriptor
			// ***
			foreach (string item in items)
			{
				returnValue.UpdateClassAttribute(item);
			}

			return returnValue;
		}

		/// <summary>
		/// Applies the <see cref="FontAwesomeStyles.Large1x"/> style to the specified icon. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="icon">The existing <see cref="FontAwesomeIcon"/> to modify.</param>
		/// <returns>A new modified instance of the <see cref="FontAwesomeIcon"/> object.</returns>
		public static FontAwesomeIcon Large1x(this FontAwesomeIcon icon)
		{
			if (icon == null)
			{
				throw new ArgumentNullException("icon");
			}

			return icon.Customize(FontAwesomeStyles.Large1x);
		}

		/// <summary>
		/// Applies the <see cref="FontAwesomeStyles.Large2x"/> style to the specified icon. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="icon">The existing <see cref="FontAwesomeIcon"/> to modify.</param>
		/// <returns>A new modified instance of the <see cref="FontAwesomeIcon"/> object.</returns>
		public static FontAwesomeIcon Large2x(this FontAwesomeIcon icon)
		{
			if (icon == null)
			{
				throw new ArgumentNullException("icon");
			}

			return icon.Customize(FontAwesomeStyles.Large2x);
		}

		/// <summary>
		/// Applies the <see cref="FontAwesomeStyles.Large3x"/> style to the specified icon. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="icon">The existing <see cref="FontAwesomeIcon"/> to modify.</param>
		/// <returns>A new modified instance of the <see cref="FontAwesomeIcon"/> object.</returns>
		public static FontAwesomeIcon Large3x(this FontAwesomeIcon icon)
		{
			if (icon == null)
			{
				throw new ArgumentNullException("icon");
			}

			return icon.Customize(FontAwesomeStyles.Large3x);
		}

		/// <summary>
		/// Applies the <see cref="FontAwesomeStyles.Large4x"/> style to the specified icon. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="icon">The existing <see cref="FontAwesomeIcon"/> to modify.</param>
		/// <returns>A new modified instance of the <see cref="FontAwesomeIcon"/> object.</returns>
		public static FontAwesomeIcon Large4x(this FontAwesomeIcon icon)
		{
			if (icon == null)
			{
				throw new ArgumentNullException("icon");
			}

			return icon.Customize(FontAwesomeStyles.Large4x);
		}

		/// <summary>
		/// Applies the <see cref="FontAwesomeStyles.Large5x"/> style to the specified icon. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="icon">The existing <see cref="FontAwesomeIcon"/> to modify.</param>
		/// <returns>A new modified instance of the <see cref="FontAwesomeIcon"/> object.</returns>
		public static FontAwesomeIcon Large5x(this FontAwesomeIcon icon)
		{
			if (icon == null)
			{
				throw new ArgumentNullException("icon");
			}

			return icon.Customize(FontAwesomeStyles.Large5x);
		}

		/// <summary>
		/// Applies the <see cref="FontAwesomeStyles.FixedWidth"/> style to the specified icon. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="icon">The existing <see cref="FontAwesomeIcon"/> to modify.</param>
		/// <returns>A new modified instance of the <see cref="FontAwesomeIcon"/> object.</returns>
		public static FontAwesomeIcon FixedWidth(this FontAwesomeIcon icon)
		{
			if (icon == null)
			{
				throw new ArgumentNullException("icon");
			}

			return icon.Customize(FontAwesomeStyles.FixedWidth);
		}

		/// <summary>
		/// Applies the <see cref="FontAwesomeStyles.ListItem"/> style to the specified icon. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="icon">The existing <see cref="FontAwesomeIcon"/> to modify.</param>
		/// <returns>A new modified instance of the <see cref="FontAwesomeIcon"/> object.</returns>
		public static FontAwesomeIcon ListItem(this FontAwesomeIcon icon)
		{
			if (icon == null)
			{
				throw new ArgumentNullException("icon");
			}

			return icon.Customize(FontAwesomeStyles.ListItem);
		}

		/// <summary>
		/// Applies the <see cref="FontAwesomeStyles.Border"/> style to the specified icon. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="icon">The existing <see cref="FontAwesomeIcon"/> to modify.</param>
		/// <returns>A new modified instance of the <see cref="FontAwesomeIcon"/> object.</returns>
		public static FontAwesomeIcon Border(this FontAwesomeIcon icon)
		{
			if (icon == null)
			{
				throw new ArgumentNullException("icon");
			}

			return icon.Customize(FontAwesomeStyles.Border);
		}

		/// <summary>
		/// Applies the <see cref="FontAwesomeStyles.PullRight"/> style to the specified icon. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="icon">The existing <see cref="FontAwesomeIcon"/> to modify.</param>
		/// <returns>A new modified instance of the <see cref="FontAwesomeIcon"/> object.</returns>
		public static FontAwesomeIcon PullRight(this FontAwesomeIcon icon)
		{
			if (icon == null)
			{
				throw new ArgumentNullException("icon");
			}

			return icon.Customize(FontAwesomeStyles.PullRight);
		}

		/// <summary>
		/// Applies the <see cref="FontAwesomeStyles.PullLeft"/> style to the specified icon. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="icon">The existing <see cref="FontAwesomeIcon"/> to modify.</param>
		/// <returns>A new modified instance of the <see cref="FontAwesomeIcon"/> object.</returns>
		public static FontAwesomeIcon PullLeft(this FontAwesomeIcon icon)
		{
			if (icon == null)
			{
				throw new ArgumentNullException("icon");
			}

			return icon.Customize(FontAwesomeStyles.PullLeft);
		}

		/// <summary>
		/// Applies the <see cref="FontAwesomeStyles.Spin"/> style to the specified icon. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="icon">The existing <see cref="FontAwesomeIcon"/> to modify.</param>
		/// <returns>A new modified instance of the <see cref="FontAwesomeIcon"/> object.</returns>
		public static FontAwesomeIcon Spin(this FontAwesomeIcon icon)
		{
			if (icon == null)
			{
				throw new ArgumentNullException("icon");
			}

			return icon.Customize(FontAwesomeStyles.Spin);
		}

		/// <summary>
		/// Applies the <see cref="FontAwesomeStyles.Rotate90"/> style to the specified icon. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="icon">The existing <see cref="FontAwesomeIcon"/> to modify.</param>
		/// <returns>A new modified instance of the <see cref="FontAwesomeIcon"/> object.</returns>
		public static FontAwesomeIcon Rotate90(this FontAwesomeIcon icon)
		{
			if (icon == null)
			{
				throw new ArgumentNullException("icon");
			}

			return icon.Customize(FontAwesomeStyles.Rotate90);
		}

		/// <summary>
		/// Applies the <see cref="FontAwesomeStyles.Rotate180"/> style to the specified icon. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="icon">The existing <see cref="FontAwesomeIcon"/> to modify.</param>
		/// <returns>A new modified instance of the <see cref="FontAwesomeIcon"/> object.</returns>
		public static FontAwesomeIcon Rotate180(this FontAwesomeIcon icon)
		{
			if (icon == null)
			{
				throw new ArgumentNullException("icon");
			}

			return icon.Customize(FontAwesomeStyles.Rotate180);
		}

		/// <summary>
		/// Applies the <see cref="FontAwesomeStyles.Rotate270"/> style to the specified icon. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="icon">The existing <see cref="FontAwesomeIcon"/> to modify.</param>
		/// <returns>A new modified instance of the <see cref="FontAwesomeIcon"/> object.</returns>
		public static FontAwesomeIcon Rotate270(this FontAwesomeIcon icon)
		{
			if (icon == null)
			{
				throw new ArgumentNullException("icon");
			}

			return icon.Customize(FontAwesomeStyles.Rotate270);
		}

		/// <summary>
		/// Applies the FontAwesomeStyles.FlipHorizontal style to the specified icon. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="icon">The existing <see cref="FontAwesomeIcon"/> to modify.</param>
		/// <returns>A new modified instance of the <see cref="FontAwesomeIcon"/> object.</returns>
		public static FontAwesomeIcon FlipHorizontal(this FontAwesomeIcon icon)
		{
			if (icon == null)
			{
				throw new ArgumentNullException("icon");
			}

			return icon.Customize(FontAwesomeStyles.FlipHorizontal);
		}

		/// <summary>
		/// Applies the <see cref="FontAwesomeStyles.FlipVertical"/> style to the specified icon. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="icon">The existing <see cref="FontAwesomeIcon"/> to modify.</param>
		/// <returns>A new modified instance of the <see cref="FontAwesomeIcon"/> object.</returns>
		public static FontAwesomeIcon FlipVertical(this FontAwesomeIcon icon)
		{
			if (icon == null)
			{
				throw new ArgumentNullException("icon");
			}

			return icon.Customize(FontAwesomeStyles.FlipVertical);
		}

		/// <summary>
		/// Applies the <see cref="FontAwesomeStyles.Inverse"/> style to the specified icon. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="icon">The existing <see cref="FontAwesomeIcon"/> to modify.</param>
		/// <returns>A new modified instance of the <see cref="FontAwesomeIcon"/> object.</returns>
		public static FontAwesomeIcon Inverse(this FontAwesomeIcon icon)
		{
			if (icon == null)
			{
				throw new ArgumentNullException("icon");
			}

			return icon.Customize(FontAwesomeStyles.Inverse);
		}

		/// <summary>
		/// Applies the <see cref="FontAwesomeStyles.Stack1x"/> style to the specified icon. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="icon">The existing <see cref="FontAwesomeIcon"/> to modify.</param>
		/// <returns>A new modified instance of the <see cref="FontAwesomeIcon"/> object.</returns>
		public static FontAwesomeIcon Stack1x(this FontAwesomeIcon icon)
		{
			if (icon == null)
			{
				throw new ArgumentNullException("icon");
			}

			return icon.Customize(FontAwesomeStyles.Stack1x);
		}

		/// <summary>
		/// Applies the <see cref="FontAwesomeStyles.Stack2x"/> style to the specified icon. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="icon">The existing <see cref="FontAwesomeIcon"/> to modify.</param>
		/// <returns>A new modified instance of the <see cref="FontAwesomeIcon"/> object.</returns>
		public static FontAwesomeIcon Stack2x(this FontAwesomeIcon icon)
		{
			if (icon == null)
			{
				throw new ArgumentNullException("icon");
			}

			return icon.Customize(FontAwesomeStyles.Stack2x);
		}

		/// <summary>
		/// Creates a stack from a list of <see cref="FontAwesomeIcon"/> objects and applies
		/// the specified styles.
		/// </summary>
		/// <param name="items">A list of <see cref="FontAwesomeIcon"/> objects.</param>
		/// <param name="styles">A list of styles to apply to the <see cref="FontAwesomeStack"/> instance.</param>
		/// <returns>A newly created <see cref="FontAwesomeStack"/> instance.</returns>
		public static FontAwesomeStack Stack(this IEnumerable<FontAwesomeIcon> items, params string[] styles)
		{
			if (items == null)
			{
				throw new ArgumentNullException("items");
			}

			if (styles == null)
			{
				throw new ArgumentNullException("styles");
			}

			return new FontAwesomeStack(items, styles);
		}

		/// <summary>
		/// Gets the class attribute value only for the given FontAwesomeIcon instance.
		/// </summary>
		/// <param name="icon">The existing <see cref="FontAwesomeIcon"/> to modify.</param>
		/// <returns>A <see cref="String"/> value containing the class attribute value from the HTML markup
		/// generated for this icon.</returns>
		public static string CssOnly(this FontAwesomeIcon icon)
		{
			return icon.ClassAttributes.Values.Aggregate(string.Empty, (o, i) => o + Constants.Space + i).TrimStart();
		}
	}
}

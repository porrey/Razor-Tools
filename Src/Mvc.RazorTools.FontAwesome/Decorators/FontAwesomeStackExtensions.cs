using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc.RazorTools.FontAwesome
{
	/// <summary>
	/// Provides a set of extension methods for a Mvc.RazorTools.FontAwesome.FontAwesomeStack
	/// object to be used within the Razor view.
	/// </summary>
	public static class FontAwesomeStackExtensions
	{
		/// <summary>
		/// Customizes an existing Mvc.RazorTools.FontAwesome.FontAwesomeStack by adding
		/// class attributes and returning the object. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="stack">The existing Mvc.RazorTools.FontAwesome.FontAwesomeStack to modify.</param>
		/// <param name="items">The class attributes to be added to the existing instance.</param>
		/// <returns>A new modified instance of the Mvc.RazorTools.FontAwesome.FontAwesomeStack object.</returns>
		public static FontAwesomeStack Customize(this FontAwesomeStack stack, params string[] items)
		{
			if (stack == null) throw new ArgumentNullException("icon");
			if (items == null) throw new ArgumentNullException("items");

			FontAwesomeStack returnValue = stack.Clone() as FontAwesomeStack;

			// ***
			// *** Make a copy of each class descriptor
			// ***
			foreach (var item in items)
			{
				returnValue.UpdateClassAttribute(item);
			}

			return returnValue;
		}

		/// <summary>
		/// Applies the FontAwesomeStyles.Large1x style to the specified icon. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="stack">The existing Mvc.RazorTools.FontAwesome.FontAwesomeStack to modify.</param>
		/// <returns>A new modified instance of the Mvc.RazorTools.FontAwesome.FontAwesomeStack object.</returns>
		public static FontAwesomeStack Large1x(this FontAwesomeStack stack)
		{
			if (stack == null) throw new ArgumentNullException("stack");
			return stack.Customize(FontAwesomeStyles.Large1x);
		}

		/// <summary>
		/// Applies the FontAwesomeStyles.Large2x style to the specified icon. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="stack">The existing Mvc.RazorTools.FontAwesome.FontAwesomeStack to modify.</param>
		/// <returns>A new modified instance of the Mvc.RazorTools.FontAwesome.FontAwesomeStack object.</returns>
		public static FontAwesomeStack Large2x(this FontAwesomeStack stack)
		{
			if (stack == null) throw new ArgumentNullException("stack");
			return stack.Customize(FontAwesomeStyles.Large2x);
		}

		/// <summary>
		/// Applies the FontAwesomeStyles.Large3x style to the specified icon. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="stack">The existing Mvc.RazorTools.FontAwesome.FontAwesomeStack to modify.</param>
		/// <returns>A new modified instance of the Mvc.RazorTools.FontAwesome.FontAwesomeStack object.</returns>
		public static FontAwesomeStack Large3x(this FontAwesomeStack stack)
		{
			if (stack == null) throw new ArgumentNullException("stack");
			return stack.Customize(FontAwesomeStyles.Large3x);
		}

		/// <summary>
		/// Applies the FontAwesomeStyles.Large4x style to the specified icon. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="stack">The existing Mvc.RazorTools.FontAwesome.FontAwesomeStack to modify.</param>
		/// <returns>A new modified instance of the Mvc.RazorTools.FontAwesome.FontAwesomeStack object.</returns>
		public static FontAwesomeStack Large4x(this FontAwesomeStack stack)
		{
			if (stack == null) throw new ArgumentNullException("stack");
			return stack.Customize(FontAwesomeStyles.Large4x);
		}

		/// <summary>
		/// Applies the FontAwesomeStyles.Large5x style to the specified icon. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="stack">The existing Mvc.RazorTools.FontAwesome.FontAwesomeStack to modify.</param>
		/// <returns>A new modified instance of the Mvc.RazorTools.FontAwesome.FontAwesomeStack object.</returns>
		public static FontAwesomeStack Large5x(this FontAwesomeStack stack)
		{
			if (stack == null) throw new ArgumentNullException("stack");
			return stack.Customize(FontAwesomeStyles.Large5x);
		}
	}
}

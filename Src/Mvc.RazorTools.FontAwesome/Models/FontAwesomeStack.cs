using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Mvc.RazorTools.FontAwesome
{
	/// <summary>
	/// Font Awesome icons can be displayed over one another to create
	/// more affects or more icons. This class provides a mechanism to
	/// stack icons using a list.
	/// </summary>
	public class FontAwesomeStack : MvcRazorObject
	{
		/// <summary>
		/// Initializes a new instance of the Mvc.RazorTools.FontAwesome.FontAwesomeStack
		/// object.
		/// </summary>
		public FontAwesomeStack()
		{
			this.IncludeIdInHtml = false;
			this.AddClassAttribute(FontAwesomeStyles.Stack);
		}

		/// <summary>
		/// Initializes anew instance of the Mvc.RazorTools.FontAwesome.FontAwesomeStack
		/// object the specified top icon.
		/// </summary>
		/// <param name="topItem">The top icon in the stack.</param>
		public FontAwesomeStack(FontAwesomeIcon topItem)
			: this()
		{
			this.Items.Add(topItem);
		}

		/// <summary>
		/// Initializes a new instance of the Mvc.RazorTools.FontAwesome.FontAwesomeStack
		/// object the specified top icon and custom class attributes.
		/// </summary>
		/// <param name="topItem">The top icon in the stack.</param>
		/// <param name="classAttributes">The custom class attributes applied to the stack HTML tag (not the icons).</param>
		public FontAwesomeStack(FontAwesomeIcon topItem, IDictionary<string,string> classAttributes)
			: this()
		{
			this.Items.Add(topItem);
			this.MergeClassAttributes(classAttributes);
		}

		/// <summary>
		/// Initializes a new instance of the Mvc.RazorTools.FontAwesome.FontAwesomeStack
		/// object the specified top and bottom icon
		/// </summary>
		/// <param name="topItem">The top icon in the stack.</param>
		/// <param name="bottomItem">The bottom icon in the stack.</param>
		public FontAwesomeStack(FontAwesomeIcon topItem, FontAwesomeIcon bottomItem)
			: this()
		{
			this.Items.Add(topItem);
			this.Items.Add(bottomItem);
		}

		/// <summary>
		/// Initializes a new instance of the Mvc.RazorTools.FontAwesome.FontAwesomeStack
		/// object the specified top icon, bottom icon and custom class attributes. 
		/// </summary>
		/// <param name="topItem">The top icon in the stack.</param>
		/// <param name="bottomItem">The bottom icon in the stack.</param>
		/// <param name="classAttributes">The custom class attributes applied to the stack HTML tag (not the icons).</param>
		public FontAwesomeStack(FontAwesomeIcon topItem, FontAwesomeIcon bottomItem, IDictionary<string, string> classAttributes)
			: this()
		{
			this.Items.Add(topItem);
			this.Items.Add(bottomItem);
			this.MergeClassAttributes(classAttributes);
		}

		/// <summary>
		/// Initializes a new instance of the Mvc.RazorTools.FontAwesome.FontAwesomeStack
		/// object the specified top icon, middle icon and bottom icon. 
		/// </summary>
		/// <param name="topItem">The top icon in the stack.</param>
		/// <param name="middleItem">The middle icon in the stack.</param>
		/// <param name="bottomItem">The bottom icon in the stack.</param>
		public FontAwesomeStack(FontAwesomeIcon topItem, FontAwesomeIcon middleItem, FontAwesomeIcon bottomItem)
			: this()
		{
			this.Items.Add(topItem);
			this.Items.Add(middleItem);
			this.Items.Add(bottomItem);
		}

		/// <summary>
		/// Initializes a new instance of the Mvc.RazorTools.FontAwesome.FontAwesomeStack
		/// object the specified top icon, middle icon, bottom icon and custom class attributes. 
		/// </summary>
		/// <param name="topItem">The top icon in the stack.</param>
		/// <param name="middleItem">The middle icon in the stack.</param>
		/// <param name="bottomItem">The bottom icon in the stack.</param>
		/// <param name="classAttributes">The custom class attributes applied to the stack HTML tag (not the icons).</param>
		public FontAwesomeStack(FontAwesomeIcon topItem, FontAwesomeIcon middleItem, FontAwesomeIcon bottomItem, IDictionary<string, string> classAttributes)
			: this()
		{
			this.Items.Add(topItem);
			this.Items.Add(middleItem);
			this.Items.Add(bottomItem);
			this.MergeClassAttributes(classAttributes);
		}

		/// <summary>
		/// Initializes a new instance of the Mvc.RazorTools.FontAwesome.FontAwesomeStack
		/// object the specified list of items. The first icon in the list is displayed
		/// on the top.
		/// </summary>
		/// <param name="items">A list of icons to be stacked.</param>
		public FontAwesomeStack(IEnumerable<FontAwesomeIcon> items)
			: this()
		{
			foreach (FontAwesomeIcon item in items)
			{
				this.Items.Add(item);
			}
		}

		/// <summary>
		/// Initializes a new instance of the Mvc.RazorTools.FontAwesome.FontAwesomeStack
		/// object the specified list of items and the specified custom class 
		/// attributes. The first icon in the list is displayed on the top.
		/// </summary>
		/// <param name="items">The list containing the stack of icons.</param>
		/// <param name="classAttributes">The custom class attributes applied to the stack HTML tag (not the icons).</param>
		public FontAwesomeStack(IEnumerable<FontAwesomeIcon> items, IDictionary<string, string> classAttributes)
			: this()
		{
			foreach (FontAwesomeIcon item in items)
			{
				this.Items.Add(item);
			}

			this.MergeClassAttributes(classAttributes);
		}

		/// <summary>
		/// Initializes a new instance of the Mvc.RazorTools.FontAwesome.FontAwesomeStack
		/// object the specified list of items and the specified custom class 
		/// attributes. The first icon in the list is displayed on the top.
		/// </summary>
		/// <param name="items">The list containing the stack of icons.</param>
		/// <param name="classAttributes">The custom class attributes applied to the stack HTML tag (not the icons).</param>
		public FontAwesomeStack(IEnumerable<FontAwesomeIcon> items, IEnumerable<string> classAttributes)
			: this()
		{
			foreach (FontAwesomeIcon item in items)
			{
				this.Items.Add(item);
			}

			this.MergeClassAttributes(classAttributes);
		}

		/// <summary>
		/// Creates a new instance of Mvc.RazorTools.FontAwesome.FontAwesomeStack with
		/// the specified items.
		/// </summary>
		/// <param name="items">A List of <see cref="FontAwesomeIcon"/> items.</param>
		/// <returns>A new Mvc.RazorTools.FontAwesome.FontAwesomeStack instance.</returns>
		public static FontAwesomeStack Create(params FontAwesomeIcon[] items)
		{
			return new FontAwesomeStack(items);
		}

		/// <summary>
		/// Gets the list of stacked icons.
		/// </summary>
		public List<FontAwesomeIcon> Items { get; } = new List<FontAwesomeIcon>();

		protected override void OnGetInnerHtml(TagBuilder html)
		{
			// ***
			// *** Build text that will place each icon between the tags
			// ***
			foreach (FontAwesomeIcon item in this.Items)
			{
				FontAwesomeIcon icon = (FontAwesomeIcon)item.Clone();

				// ***
				// *** The icon must have either the Stack1x or Stack2x attribute set
				// ***
				if (!icon.ClassAttributes.ContainsKey(FontAwesomeStyles.Stack1x) &&
					!icon.ClassAttributes.ContainsKey(FontAwesomeStyles.Stack2x))
				{
					// ***
					// *** Default to Stack1x
					// ***
					icon.AddClassAttribute(FontAwesomeStyles.Stack1x);
				}

				// ***
				// *** Add the HTML markup to the TagBuilder object
				// ***
				throw new System.Exception("Come back and fix this!");
				//html.InnerHtml += icon.Html.ToString();
			}
		}

		protected override string OnInitializeHtmlTag()
		{
			return "span";
		}

		protected override object OnClone()
		{
			FontAwesomeStack returnValue = new FontAwesomeStack();

			foreach (FontAwesomeIcon item in this.Items)
			{
				returnValue.Items.Add((FontAwesomeIcon)item.Clone());
			}

			// ***
			// *** Cloning always unlocks the object
			// ***
			returnValue.Locked = false;

			returnValue.MergeClassAttributes(this.ClassAttributes);
			return returnValue;
		}
	}
}

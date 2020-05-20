using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Mvc.RazorTools.FontAwesome
{
	/// <summary>
	/// Font Awesome icons can be displayed over one another to create
	/// more affects or more icons. This class provides a mechanism to
	/// stack icons using a list.
	/// </summary>
	public class FaStack : MvcRazorObject
	{
		/// <summary>
		/// Initializes a new instance of the Mvc.RazorTools.FontAwesome.FontAwesomeStack
		/// object.
		/// </summary>
		public FaStack()
		{
			this.IncludeIdInHtml = false;
			this.AddClassAttribute(FaStackAttributes.Stack.ClassAttribute);
		}

		/// <summary>
		/// Initializes anew instance of the Mvc.RazorTools.FontAwesome.FontAwesomeStack
		/// object the specified top icon.
		/// </summary>
		/// <param name="topItem">The top icon in the stack.</param>
		public FaStack(FaIcon topItem)
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
		public FaStack(FaIcon topItem, IDictionary<string,string> classAttributes)
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
		public FaStack(FaIcon topItem, FaIcon bottomItem)
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
		public FaStack(FaIcon topItem, FaIcon bottomItem, IDictionary<string, string> classAttributes)
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
		public FaStack(FaIcon topItem, FaIcon middleItem, FaIcon bottomItem)
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
		public FaStack(FaIcon topItem, FaIcon middleItem, FaIcon bottomItem, IDictionary<string, string> classAttributes)
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
		public FaStack(IEnumerable<FaIcon> items)
			: this()
		{
			foreach (FaIcon item in items)
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
		public FaStack(IEnumerable<FaIcon> items, IDictionary<string, string> classAttributes)
			: this()
		{
			foreach (FaIcon item in items)
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
		public FaStack(IEnumerable<FaIcon> items, IEnumerable<string> classAttributes)
			: this()
		{
			foreach (FaIcon item in items)
			{
				this.Items.Add(item);
			}

			this.MergeClassAttributes(classAttributes);
		}

		/// <summary>
		/// Creates a new instance of Mvc.RazorTools.FontAwesome.FontAwesomeStack with
		/// the specified items.
		/// </summary>
		/// <param name="items">A List of <see cref="FaIcon"/> items.</param>
		/// <returns>A new Mvc.RazorTools.FontAwesome.FontAwesomeStack instance.</returns>
		public static FaStack Create(params FaIcon[] items)
		{
			return new FaStack(items);
		}

		/// <summary>
		/// Gets the list of stacked icons.
		/// </summary>
		public List<FaIcon> Items { get; } = new List<FaIcon>();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="tagBuilder"></param>
		protected override void OnGetInnerHtml(TagBuilder tagBuilder)
		{
			// ***
			// *** Build text that will place each icon between the tags
			// ***
			foreach (FaIcon item in this.Items)
			{
				FaIcon icon = (FaIcon)item.Clone();

				// ***
				// *** The icon must have either the Stack1x or Stack2x attribute set
				// ***
				if (!icon.ClassAttributes.ContainsKey(FaStackAttributes.Stack1x.ClassAttribute) &&
					!icon.ClassAttributes.ContainsKey(FaStackAttributes.Stack2x.ClassAttribute))
				{
					// ***
					// *** Default to Stack1x
					// ***
					icon.AddClassAttribute(FaStackAttributes.Stack1x.ClassAttribute);
				}

				// ***
				// *** Add the HTML markup to the TagBuilder object
				// ***
				throw new System.Exception("Come back and fix this!");
				//html.InnerHtml += icon.Html.ToString();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected override string OnInitializeHtmlTag()
		{
			return "span";
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected override object OnClone()
		{
			FaStack returnValue = new FaStack();

			foreach (FaIcon item in this.Items)
			{
				returnValue.Items.Add((FaIcon)item.Clone());
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

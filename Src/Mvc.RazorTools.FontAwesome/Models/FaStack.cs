//
// Copyright(C) 2014-2020, Daniel M. Porrey. All rights reserved.
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published
// by the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program. If not, see http://www.gnu.org/licenses/.
//
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Mvc.RazorTools.FontAwesome
{
	/// <summary>
	/// Font Awesome icons can be displayed over one another to create
	/// more affects or more icons. This class provides a mechanism to
	/// stack icons using a list.
	/// </summary>
	public class FaStack : RazorToolsObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="FaStack"/>
		/// object.
		/// </summary>
		public FaStack()
		{
			this.IncludeIdInHtml = false;
			this.AddClassAttribute(FaStackAttributes.Stack.ClassAttribute);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FaStack"/>.
		/// object.
		/// </summary>
		public FaStack(string id)
		{
			this.Id = id;
			this.IncludeIdInHtml = false;
			this.AddClassAttribute(FaStackAttributes.Stack.ClassAttribute);
		}

		/// <summary>
		/// Initializes anew instance of the <see cref="FaStack"/>
		/// object the specified top icon.
		/// </summary>
		/// <param name="topItem">The top icon in the stack.</param>
		public FaStack(FaIcon topItem)
			: this()
		{
			this.Items.Add(topItem);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FaStack"/>
		/// object the specified top icon and custom class attributes.
		/// </summary>
		/// <param name="topItem">The top icon in the stack.</param>
		/// <param name="classAttributes">The custom class attributes applied to the stack HTML tag (not the icons).</param>
		public FaStack(FaIcon topItem, IEnumerable<string> classAttributes)
			: this()
		{
			this.Items.Add(topItem);
			this.MergeClassAttributes(classAttributes);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FaStack"/>
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
		/// Initializes a new instance of the <see cref="FaStack"/>
		/// object the specified top icon, bottom icon and custom class attributes. 
		/// </summary>
		/// <param name="topItem">The top icon in the stack.</param>
		/// <param name="bottomItem">The bottom icon in the stack.</param>
		/// <param name="classAttributes">The custom class attributes applied to the stack HTML tag (not the icons).</param>
		public FaStack(FaIcon topItem, FaIcon bottomItem, IEnumerable<string> classAttributes)
			: this()
		{
			this.Items.Add(topItem);
			this.Items.Add(bottomItem);
			this.MergeClassAttributes(classAttributes);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FaStack"/>
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
		/// Initializes a new instance of the <see cref="FaStack"/>
		/// object the specified top icon, middle icon, bottom icon and custom class attributes. 
		/// </summary>
		/// <param name="topItem">The top icon in the stack.</param>
		/// <param name="middleItem">The middle icon in the stack.</param>
		/// <param name="bottomItem">The bottom icon in the stack.</param>
		/// <param name="classAttributes">The custom class attributes applied to the stack HTML tag (not the icons).</param>
		public FaStack(FaIcon topItem, FaIcon middleItem, FaIcon bottomItem, IEnumerable<string> classAttributes)
			: this()
		{
			this.Items.Add(topItem);
			this.Items.Add(middleItem);
			this.Items.Add(bottomItem);
			this.MergeClassAttributes(classAttributes);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FaStack"/>
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
		/// Initializes a new instance of the <see cref="FaStack"/>
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
		/// Creates a new instance of <see cref="FaStack"/> with
		/// the specified items.
		/// </summary>
		/// <param name="items">A List of <see cref="FaIcon"/> items.</param>
		/// <returns>A new <see cref="FaStack"/> instance.</returns>
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
			FaStack returnValue = new FaStack(this.Id)
			{
				//
				// Cloning always unlocks the object
				//
				Locked = false,
				Id = this.Id,
				HtmlTag = this.HtmlTag,
				Name = this.Name,
				IncludeIdInHtml = this.IncludeIdInHtml
			};

			foreach (FaIcon item in this.Items)
			{
				returnValue.Items.Add((FaIcon)item.Clone());
			}

			returnValue.MergeClassAttributes(this.ClassAttributes);
			returnValue.MergeAttributes(this.Attributes);
			returnValue.MergeStyles(this.Styles);

			return returnValue;
		}
	}
}

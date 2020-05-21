// ***
// *** Copyright(C) 2014-2020, Daniel M. Porrey. All rights reserved.
// *** 
// *** This program is free software: you can redistribute it and/or modify
// *** it under the terms of the GNU Lesser General Public License as published
// *** by the Free Software Foundation, either version 3 of the License, or
// *** (at your option) any later version.
// *** 
// *** This program is distributed in the hope that it will be useful,
// *** but WITHOUT ANY WARRANTY; without even the implied warranty of
// *** MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// *** GNU Lesser General Public License for more details.
// *** 
// *** You should have received a copy of the GNU Lesser General Public License
// *** along with this program. If not, see http://www.gnu.org/licenses/.
// ***
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Mvc.RazorTools
{
	/// <summary>
	/// Provides a default abstract implementation of the <see cref="IMvcRazorObject"/> interface.
	/// </summary>
	[DefaultProperty("Html")]
	public class MvcRazorObject : IMvcRazorObject, IHtmlContent
	{
		/// <summary>
		/// Constants used internally.
		/// </summary>
		internal static class Constants
		{
			/// <summary>
			/// This is the name of the Id element in the HTML markup.
			/// </summary>
			public static string IdAttributeName = "id";

			/// <summary>
			/// A space.
			/// </summary>
			public static string Space = " ";
		}

		// ***
		// *** Fields for properties that are read-only
		// *** when the object is locked.
		// ***
		private string _id = null;
		private string _htmlTag = null;
		private string _name = null;
		private bool _locked = false;

		/// <summary>
		/// Initializes a new instance of a <see cref="MvcRazorObject"/> object.
		/// </summary>
		protected MvcRazorObject()
		{
		}

		/// <summary>
		/// Initializes a new instance of a <see cref="MvcRazorObject"/> object with the
		/// specified Id.
		/// </summary>
		/// <param name="id">The CSS style sheet name of the icon this instance represents.</param>
		protected MvcRazorObject(string id)
			: this()
		{
			this.Id = id;
		}

		#region Public Members
		/// <summary>
		/// Gets/sets the HTML node ID for this object. Read-only if this instanced is locked.
		/// </summary>
		public virtual string Id
		{
			get
			{
				if (_id == null)
				{
					_id = this.OnInitializeId();
				}

				return _id;
			}
			set
			{
				if (!this.Locked)
				{
					_id = value;
				}
				else
				{
					throw new ModifyLockedInstanceException();
				}
			}
		}

		/// <summary>
		/// Gets/sets value that indicates of this instance is locked. Once locked,
		/// the instance cannot be unlocked.
		/// </summary>
		public virtual bool Locked
		{
			get
			{
				return _locked;
			}
			set
			{
				if (!this.Locked)
				{
					_locked = value;
				}
				else
				{
					throw new ModifyLockedInstanceException();
				}
			}
		}

		/// <summary>
		/// Gets/sets the HTML tag that is used to represent the object when the
		/// the HTML markup is generated. This value should be the text portion of
		/// the tag only.
		/// </summary>
		public virtual string HtmlTag
		{
			get
			{
				if (_htmlTag == null)
				{
					_htmlTag = this.OnInitializeHtmlTag();
				}

				return _htmlTag;
			}
			set
			{
				_htmlTag = value;
			}
		}

		/// <summary>
		/// Gets/sets the name of this instance. This value is for display or managing
		/// purposes only and is not used internally by this library. Read-only if 
		/// this instanced is locked.
		/// </summary>
		public string Name
		{
			get
			{
				if (_name == null)
				{
					_name = this.OnInitializeName();
				}

				return _name;
			}
			set
			{
				if (!this.Locked)
				{
					_name = value;
				}
				else
				{
					throw new ModifyLockedInstanceException();
				}
			}
		}

		/// <summary>
		/// Gets/sets value that determines if the element Id tag is included in the
		/// Class Attributes HTL.
		/// </summary>
		public bool IncludeIdInHtml { get; set; }

		/// <summary>
		/// Gets an IHtmlContent object containing the HTML markup for this instance.
		/// </summary>
		public virtual IHtmlContent Html
		{
			get
			{
				return this.OnGetHtml();
			}
		}

		/// <summary>
		/// Returns a deep copy of this instance.
		/// </summary>
		/// <returns>A newly initialized MVC Razor object.</returns>
		public virtual object Clone()
		{
			return this.OnClone();
		}
		#endregion

		#region Attributes
		/// <summary>
		/// Gets a list of attributes added when formatting the HTML markup.
		/// </summary>
		public IDictionary<string, string> Attributes { get; set; } = new Dictionary<string, string>();

		/// <summary>
		/// Merges a set of attributes with the current items.
		/// </summary>
		/// <param name="items">A list of attribute names and values to be merged
		/// into the current set in this instance.</param>
		public virtual void MergeAttributes(IDictionary<string, string> items)
		{
			if (items != null)
			{
				// ***
				// *** Make a copy of each class descriptor
				// ***
				foreach (KeyValuePair<string, string> item in items)
				{
					this.UpdateAttribute(item.Key, item.Value);
				}
			}
		}

		/// <summary>
		/// Update an exiting attribute contained in this instance. If the value exists 
		/// it will be replaced otherwise it will added to the list.
		/// </summary>
		/// <param name="name">A <see cref="String"/> representing the attribute name.</param>
		/// <param name="value">A <see cref="String"/> value containing the attribute to be included in the HTML markup.</param>
		public virtual void UpdateAttribute(string name, string value)
		{
			if (this.Attributes.ContainsKey(name))
			{
				this.Attributes[name] = value;
			}
			else
			{
				this.AddAttribute(name, value);
			}
		}

		/// <summary>
		/// Add an attribute to the set contained within this instance when formatting the HTML markup.
		/// </summary>
		/// <param name="name">A <see cref="String"/> representing the attribute name.</param>
		/// <param name="value">A <see cref="String"/> value containing the attribute to be included in the HTML markup.</param>
		public virtual void AddAttribute(string name, string value)
		{
			this.Attributes.Add(name, value);
		}
		#endregion

		#region Styles
		/// <summary>
		/// Gets a list of styles added when formatting the HTML markup.
		/// </summary>
		public IDictionary<string, string> Styles { get; set; } = new Dictionary<string, string>();

		/// <summary>
		/// Merges a set of styles with the current items.
		/// </summary>
		/// <param name="items">A list of style names and values to be merged
		/// into the current set in this instance.</param>
		public virtual void MergeStyles(IDictionary<string, string> items)
		{
			if (items != null)
			{
				// ***
				// *** Make a copy of each class descriptor
				// ***
				foreach (KeyValuePair<string, string> item in items)
				{
					this.UpdateStyle(item.Key, item.Value);
				}
			}
		}

		/// <summary>
		/// Update an exiting style contained in this instance. If the value exists 
		/// it will be replaced otherwise it will added to the list.
		/// </summary>
		/// <param name="name">A <see cref="String"/> representing the style name.</param>
		/// <param name="value">A <see cref="String"/> representing the style value.</param>
		public virtual void UpdateStyle(string name, string value)
		{
			if (this.Styles.ContainsKey(name))
			{
				this.Styles[name] = value;
			}
			else
			{
				this.Styles.Add(name, value);
			}
		}

		/// <summary>
		/// Add a style to the set contained within this instance when formatting the HTML markup.
		/// </summary>
		/// <param name="name">A <see cref="String"/> representing the style name.</param>
		/// <param name="value">A <see cref="String"/> representing the style value..</param>
		public virtual void AddStyle(string name, string value)
		{
			this.Styles.Add(name, value);
		}
		#endregion

		#region Class Attributes
		/// <summary>
		/// Gets a list of class attributes added when formatting the HTML tag.
		/// </summary>
		public virtual IDictionary<string, string> ClassAttributes { get; set; } = new Dictionary<string, string>();

		/// <summary>
		/// Add a custom class attribute to the set contained within this instance. The
		/// key and the value will contain the value of 'item'. Item is the value that 
		/// will be used when formatting the HTML class attribute.
		/// </summary>
		/// <param name="item"></param>
		public virtual void AddClassAttribute(string item)
		{
			this.ClassAttributes.Add(item, item);
		}

		/// <summary>
		/// Add a custom class attribute to the set contained within this instance. the key is used for 
		/// here for lookup and replacement of existing attribute. Item is the value that will be used when 
		/// formatting the HTML class attribute.
		/// </summary>
		/// <param name="key">A <see cref="String"/> value to provide a key to lookup the attribute in this set.</param>
		/// <param name="item">A <see cref="String"/> value containing the attribute to be included in the HTML markup.</param>
		public virtual void AddClassAttribute(string key, string item)
		{
			this.ClassAttributes.Add(key, item);
		}

		/// <summary>
		/// Update an exiting custom class attribute contained in this instance. The value for
		/// item is to lookup the existing attribute. If the value exists it will be replaced 
		/// otherwise it will added to the list.
		/// </summary>
		/// <param name="item">A <see cref="String"/> value containing the attribute to be included in the HTML markup.</param>
		public virtual void UpdateClassAttribute(string item)
		{
			if (this.ClassAttributes.ContainsKey(item))
			{
				this.ClassAttributes[item] = item;
			}
			else
			{
				this.AddClassAttribute(item);
			}
		}

		/// <summary>
		/// Update an exiting custom class attribute contained in this instance. The value for
		/// key is used to lookup the existing attribute. If the value exists it will be 
		/// replaced otherwise it will added to the list.
		/// </summary>
		/// <param name="key">A <see cref="String"/> value to provide a key to lookup the attribute in this set.</param>
		/// <param name="item">A <see cref="String"/> value containing the attribute to be included in the HTML markup.</param>
		public virtual void UpdateClassAttribute(string key, string item)
		{
			if (this.ClassAttributes.ContainsKey(key))
			{
				this.ClassAttributes[key] = item;
			}
			else
			{
				this.AddClassAttribute(key, item);
			}
		}

		/// <summary>
		/// Merges a set of class attributes with the current items.
		/// </summary>
		/// <param name="items">A list of attribute keys and values to be merged
		/// into the current set in this instance.</param>
		public virtual void MergeClassAttributes(IDictionary<string, string> items)
		{
			if (items != null)
			{
				// ***
				// *** Make a copy of each class descriptor
				// ***
				foreach (KeyValuePair<string, string> item in items)
				{
					this.UpdateClassAttribute(item.Key, item.Value);
				}
			}
		}

		/// <summary>
		/// Merges a set of class attributes with the current items.
		/// </summary>
		/// <param name="items">A list of attribute values to be merged
		/// into the current set in this instance.</param>
		public virtual void MergeClassAttributes(IEnumerable<string> items)
		{
			if (items != null)
			{
				// ***
				// *** Make a copy of each class descriptor
				// ***
				foreach (string item in items)
				{
					this.UpdateClassAttribute(item);
				}
			}
		}
		#endregion

		#region Protected Members
		/// <summary>
		/// Gets an MvcHtmlString object containing the HTML markup for this instance. This method must be overridden.
		/// </summary>
		/// <returns>A System.Web.Mvc.MvcHtmlString object containing the HTML markup for this object.</returns>
		protected virtual IHtmlContent OnGetHtml()
		{
			TagBuilder tag = this.OnGetHtmlStart();

			this.OnGetHtmlId(tag);
			this.OnGetHtmlClassAttributes(tag);
			this.OnGetHtmlAttributes(tag);
			this.OnGetHtmlStyles(tag);
			this.OnGetInnerHtml(tag);
			this.OnGetHtmlStartComplete(tag);

			return tag;
		}

		/// <summary>
		/// OnInitializeId
		/// </summary>
		protected virtual string OnInitializeId()
		{
			return Guid.NewGuid().ToString();
		}

		/// <summary>
		/// Allows the derived class to initialize the Name without
		/// the need to override the name property. The default
		/// implementation is to use a HTML Tag and the Id value.
		/// </summary>
		/// <returns>A <see cref="String"/> representing the Name for this instance.</returns>
		protected virtual string OnInitializeName()
		{
			return String.Format("{0}-{1}", this.HtmlTag, this.Id);
		}

		/// <summary>
		/// Allows the derived class to initialize the HTML Tag without
		/// the need to override the HtmlTag property. The default
		/// implementation is to use 'span' as the HtmlTag.
		/// </summary>
		/// <returns>A <see cref="String"/> representing the HTML Tag for this instance.</returns>
		protected virtual string OnInitializeHtmlTag()
		{
			return null;
		}

		/// <summary>
		/// Allows the derived class to respond to the Clone() method
		/// without the need to override the HtmlTag property.
		/// </summary>
		/// <returns>Returns a deep copy of this instance.</returns>
		protected virtual object OnClone()
		{
			MvcRazorObject returnValue = new MvcRazorObject(this.Id)
			{
				HtmlTag = this.HtmlTag,
				Name = this.Name,
				ClassAttributes = this.ClassAttributes,

				// ***
				// *** Cloning always unlocks the object
				// ***
				Locked = false
			};

			return returnValue;
		}

		/// <summary>
		/// Creates the HTML TagBuilder object used to create the HTML markup. This
		/// step is called first in a series of steps to build the markup.
		/// </summary>
		/// <returns>The TagBuilder object used to create the HTML markup.</returns>
		protected virtual TagBuilder OnGetHtmlStart()
		{
			return new TagBuilder(this.HtmlTag);
		}

		/// <summary>
		/// Adds the id attribute to the HTML markup tag. This is the second step in
		/// a series of steps to build the markup.
		/// </summary>
		/// <param name="tag">The TagBuilder object used to create the HTML markup.</param>
		protected virtual void OnGetHtmlId(TagBuilder tag)
		{
			if (this.IncludeIdInHtml)
			{
				if (!tag.Attributes.ContainsKey(Constants.IdAttributeName))
				{
					tag.Attributes.Add(Constants.IdAttributeName, this.Id);
				}
			}
		}

		/// <summary>
		/// Adds the class attribute to the HTML markup tag. This is the third step in
		/// a series of steps to build the markup.
		/// </summary>
		/// <param name="tag">The TagBuilder object used to create the HTML markup.</param>
		protected virtual void OnGetHtmlClassAttributes(TagBuilder tag)
		{
			// ***
			// *** Add these in reverse order
			// ***
			foreach (KeyValuePair<string, string> item in this.ClassAttributes.Reverse())
			{
				tag.AddCssClass(item.Value);
			}
		}

		/// <summary>
		/// Adds the tag attribute to the HTML markup tag. This is the fourth step in
		/// a series of steps to build the markup.
		/// </summary>
		/// <param name="tag">The TagBuilder object used to create the HTML markup.</param>
		protected virtual void OnGetHtmlAttributes(TagBuilder tag)
		{
			// ***
			// *** Add these in reverse order
			// ***
			foreach (KeyValuePair<string, string> item in this.Attributes.Reverse())
			{
				tag.Attributes.Add(item.Key, item.Value);
			}
		}

		/// <summary>
		/// Adds the tag attribute to the HTML markup tag. This is the fifth step in
		/// a series of steps to build the markup.
		/// </summary>
		/// <param name="tag">The TagBuilder object used to create the HTML markup.</param>
		protected virtual void OnGetHtmlStyles(TagBuilder tag)
		{
			if (this.Styles.Count() > 0)
			{
				// ***
				// *** Create a StringBuilder to concatenate the
				// *** styles into...
				// ***
				StringBuilder stylesValue = new StringBuilder();

				// ***
				// *** Concatenate the styles into a single string
				// ***
				foreach (KeyValuePair<string, string> style in this.Styles)
				{
					stylesValue.Append(String.Format("{0}: {1};", style.Key, style.Value));
				}

				// ***
				// *** Set the styles attribute
				// ***
				tag.Attributes.Add("style", stylesValue.ToString());
			}
		}

		/// <summary>
		/// Called to get inner HTML markup. This is the sixth 
		/// step in a series of steps to build the markup.
		/// </summary>
		/// <param name="html">The TagBuilder object used to create the HTML markup.</param>
		protected virtual void OnGetInnerHtml(TagBuilder html)
		{
		}

		/// <summary>
		/// Called to add any final attributes to the HTML markup tag. This is the seventh 
		/// and final step in a series of steps to build the markup.
		/// </summary>
		/// <param name="html">The TagBuilder object used to create the HTML markup.</param>
		protected virtual void OnGetHtmlStartComplete(TagBuilder html)
		{
		}
		#endregion

		#region IHtmlContent
		/// <summary>
		/// Writes the content by encoding it with the specified encoder to the specified
		/// writer.
		/// </summary>
		/// <param name="writer">The <see cref="TextWriter"/> to which the content is written.</param>
		/// <param name="encoder">The <see cref="HtmlEncoder"/> which encodes the content to be written.</param>
		public void WriteTo(TextWriter writer, HtmlEncoder encoder)
		{
			this.Html.WriteTo(writer, encoder);
		}
		#endregion
	}
}
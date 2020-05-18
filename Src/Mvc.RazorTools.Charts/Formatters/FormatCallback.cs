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

namespace Mvc.RazorTools.Charts
{
	/// <summary>
	/// A formatter used for JavaScript callbacks.
	/// </summary>
	public abstract class CallbackFormatter : IFormatCallback
	{
		/// <summary>
		/// Creates an instance of <see cref="CallbackFormatter"/> with
		/// the specified type.
		/// </summary>
		/// <param name="type"></param>
		protected CallbackFormatter(string type)
		{
			this.Type = type;
		}

		/// <summary>
		/// Gets the Type name that this formatter represents.
		/// </summary>
		public string Type { get; protected set; }

		/// <summary>
		/// Gets/sets the format string for this formatter.
		/// </summary>
		public string FormatString { get; set; }

		/// <summary>
		/// Gets the attribute value written tot he TML tag for this formatter.
		/// </summary>
		public string AttributeValue
		{
			get
			{
				return String.Format("{0}({1})", this.Type.ToLower(), this.FormatString);
			}
		}
	}
}

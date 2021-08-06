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
using System;

namespace Mvc.RazorTools
{
	/// <summary>
	/// 
	/// </summary>
	[Obsolete("Derive objects from RazorToolsObject")]
	public class MvcRazorObject : RazorToolsObject
	{
		/// <summary>
		/// 
		/// </summary>
		protected MvcRazorObject()
			: base()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		protected MvcRazorObject(string id)
			: base(id)
		{
		}
	}

	/// <summary>
	/// Legacy interface.
	/// </summary>
	[Obsolete("Use IMvcRazorAttributes.")]
	public interface IMvcRazorAttributes : IRazorToolsAttributes
	{
	}

	/// <summary>
	/// Legacy interface.
	/// </summary>
	[Obsolete("Use IMvcRazorStyles.")]
	public interface IMvcRazorStyles : IRazorToolsStyles
	{
	}

	/// <summary>
	/// Legacy interface.
	/// </summary>
	[Obsolete("Use IMvcRazorObject.")]
	public interface IMvcRazorObject : IRazorToolsObject
	{
	}

	/// <summary>
	/// Legacy interface.
	/// </summary>
	[Obsolete("Use IMvcRazorClassAttributes.")]
	public interface IMvcRazorClassAttributes : IRazorToolsClassAttributes
	{
	}
}

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
using System.Diagnostics.CodeAnalysis;

namespace Mvc.RazorTools.FontAwesome
{
	/// <summary>
	/// Provides a set of extension methods for a <see cref="FaStack"/>
	/// object to be used within the Razor view.
	/// </summary>
	public static class FaStackExtensions
	{
		/// <summary>
		/// Customizes an existing <see cref="FaStack"/> by adding
		/// class attributes and returning the object. This method can be chained to
		/// apply multiple styles.
		/// </summary>
		/// <param name="stack">The existing <see cref="FaStack"/> to modify.</param>
		/// <param name="items">The class attributes to be added to the existing instance.</param>
		/// <returns>A new modified instance of the <see cref="FaStack"/> object.</returns>
		public static FaStack Customize([NotNull]this FaStack stack, [NotNull]params string[] items)
		{
			FaStack returnValue = stack.Clone() as FaStack;
			
			returnValue.MergeClassAttributes(stack.ClassAttributes);
			returnValue.MergeAttributes(stack.Attributes);
			returnValue.MergeStyles(stack.Styles);
			returnValue.MergeClassAttributes(items);
			
			return returnValue;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="stack"></param>
		/// <param name="style"></param>
		/// <returns></returns>
		public static FaStack WithStyle([NotNull]this FaStack stack, [NotNull]FaStyle style)
		{
			return stack.Customize(style.ClassAttribute);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="stack"></param>
		/// <param name="size"></param>
		/// <returns></returns>
		public static FaStack WithSize([NotNull]this FaStack stack, [NotNull]FaSize size)
		{
			return stack.Customize(size.ClassAttribute);
		}
	}
}

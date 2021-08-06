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
namespace Mvc.RazorTools.Charts
{
	/// <summary>
	/// Interface specification for a callback formatter used by the
	/// JavaScript library for formatting display values.
	/// </summary>
	public interface IFormatCallback
	{
		/// <summary>
		/// Gets/sets the string used for formatting the display.
		/// </summary>
		string FormatString { get; set; }

		/// <summary>
		/// Gets the unique string name representing the type
		/// of formatter.
		/// </summary>
		string Type { get; }

		/// <summary>
		/// Gets the attribute value written in the HTML tag for
		/// this formatter.
		/// </summary>
		string AttributeValue { get; }
	}
}

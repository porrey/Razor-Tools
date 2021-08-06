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
using System.Linq;

namespace Mvc.RazorTools.FontAwesome
{
	/// <summary>
	/// Includes the known icons in the Font Awesome set for version [%VERSION%];
	/// </summary>
	public class FaIconSet
	{
		/// <summary>
		/// Gets the version of Font Awesome that this library is based on.
		/// </summary>
		public static string Version => "[%VERSION%]";

		/// <summary>
		/// Gets the number of icons defined in the current version of Font Awesome. Note this number
		/// will be greater than the count shown on the FontAwesome web site due to the icons that are
		/// aliased.
		/// </summary>
		public static int IconCount => AllItems.Count();

		/// <summary>
		/// Gets a Dictionary of predefined icons by class name. This dictionary
		/// allows querying of the icons using LINQ.
		/// </summary>
		public static Dictionary<string, FaIcon> AllItems { get; } = new Dictionary<string, FaIcon>
		{
//[%CODE%]
		};
	}
}
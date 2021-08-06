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

namespace Mvc.RazorTools.FontAwesome
{
	/// <summary>
	/// Defines the license required to use a specific icon.
	/// </summary>
	[Flags]
	public enum FaLicenseType
	{
		/// <summary>
		/// The license type has not been specified.
		/// </summary>
		None = 0,
		/// <summary>
		/// Specifies that an icon can be used with a free license.
		/// </summary>
		Free = 1,
		/// <summary>
		/// Specifies that an icon requires the pro license.
		/// </summary>
		Pro = 2
	}
}
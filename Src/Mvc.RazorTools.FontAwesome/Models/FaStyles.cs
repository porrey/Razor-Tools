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
namespace Mvc.RazorTools.FontAwesome
{
	/// <summary>
	/// Defines the possible styles to use with a FontAwesome icon.
	/// </summary>
	public static class FaStyles
	{
		/// <summary>
		/// The icon is to be displayed with the Solid style.
		/// </summary>
		public static FaStyle Solid = new FaStyle()
		{
			Name = "Solid",
			ClassAttribute = "fas"
		};

		/// <summary>
		/// The icon is to be displayed with the Regular style.
		/// </summary>
		public static FaStyle Regular = new FaStyle()
		{
			Name = "Regular",
			ClassAttribute = "far"
		};

		/// <summary>
		/// The icon is to be displayed with the Light style.
		/// </summary>
		public static FaStyle Light = new FaStyle()
		{
			Name = "Light",
			ClassAttribute = "fal"
		};

		/// <summary>
		/// The icon is to be displayed with the Duotone style.
		/// </summary>
		public static FaStyle Duotone = new FaStyle()
		{
			Name = "Duotone",
			ClassAttribute = "fad"
		};
	}
}

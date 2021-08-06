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
	/// 
	/// </summary>
	public static class FaOptions
	{
		/// <summary>
		/// 
		/// </summary>
		public static FaOption Border = new FaOption()
		{
			Name = "Border",
			ClassAttribute = "fa-border"
		};

		/// <summary>
		/// 
		/// </summary>
		public static FaOption FixedWidth = new FaOption()
		{
			Name = "FixedWidth",
			ClassAttribute = "fa-fw"
		};

		/// <summary>
		/// 
		/// </summary>
		public static FaOption Inverse = new FaOption()
		{
			Name = "Inverse",
			ClassAttribute = "fa-inverse"
		};

		/// <summary>
		/// 
		/// </summary>
		public static FaOption PullRight = new FaOption()
		{
			Name = "PullRight",
			ClassAttribute = "fa-pull-right"
		};

		/// <summary>
		/// 
		/// </summary>
		public static FaOption PullLeft = new FaOption()
		{
			Name = "PullLeft",
			ClassAttribute = "fa-pull-left"
		};

		/// <summary>
		/// 
		/// </summary>
		public static FaOption SwapOpacity = new FaOption()
		{
			Name = "SwapOpacity",
			ClassAttribute = "fa-swap-opacity"
		};

		/// <summary>
		/// 
		/// </summary>
		public const string Ul = "fa-ul";

		/// <summary>
		/// 
		/// </summary>
		public const string Li = "fa-li";
	}
}

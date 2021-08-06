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
	public static class FaStackAttributes
	{
		/// <summary>
		/// 
		/// </summary>
		public static FaStackAttribute Stack = new FaStackAttribute()
		{
			Name = "Stack",
			ClassAttribute = "fa-stack"
		};

		/// <summary>
		/// 
		/// </summary>
		public static FaStackAttribute Stack1x = new FaStackAttribute()
		{
			Name = "Stack1x",
			ClassAttribute = "fa-stack-1x"
		};

		/// <summary>
		/// 
		/// </summary>
		public static FaStackAttribute Stack2x = new FaStackAttribute()
		{
			Name = "Stack2x",
			ClassAttribute = "fa-stack-2x"
		};
	}
}

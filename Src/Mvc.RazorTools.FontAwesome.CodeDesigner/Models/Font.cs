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
using System.Collections.Generic;

namespace Mvc.RazorTools.FontAwesome.CodeDesigner
{
	[Flags]
	public enum LicenseType
	{
		Free = 1,
		Pro = 2
	}

	public class Font
	{
		public string Id { get; set; }
		public int Unicode { get; set; }
		public string HexCode { get; set; }
		public IList<string> FreeStyles { get; set; } = new string[0];
		public IList<string> ProStyles { get; set; } = new string[0];
		public LicenseType License { get; set; }
		public string ClassName { get; set; }

		public override string ToString()
		{
			return $"{this.Id}, Class Name = {this.ClassName}, License = {this.License}";
		}

		public override bool Equals(object obj)
		{
			bool returnValue = false;

			if (obj is Font font)
			{
				returnValue = (font.Id == this.Id);
			}

			return returnValue;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(this.Id);
		}
	}
}

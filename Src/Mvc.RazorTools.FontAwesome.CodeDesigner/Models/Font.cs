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

// ***
// *** Copyright(C) 2019-2020, Daniel M. Porrey. All rights reserved.
// *** 
// *** This program is free software: you can redistribute it and/or modify
// *** it under the terms of the GNU Lesser General Public License as published
// *** by the Free Software Foundation, either version 3 of the License, or
// *** (at your option) any later version.
// *** 
// *** This program is distributed in the hope that it will be useful,
// *** but WITHOUT ANY WARRANTY; without even the implied warranty of
// *** MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// *** GNU Lesser General Public License for more details.
// *** 
// *** You should have received a copy of the GNU Lesser General Public License
// *** along with this program. If not, see http://www.gnu.org/licenses/.
// ***
namespace Mvc.RazorTools.Charts
{
	/// <summary>
	/// A formatter for formatting percentages.
	/// </summary>
	public class PercentFormatter : CallbackFormatter
	{
		/// <summary>
		/// Creates an instance of a <see cref="PercentFormatter"/>
		/// with the specified number of decimal places.
		/// </summary>
		/// <param name="decimalPlaces">The number of decimal places to display.</param>
		public PercentFormatter(int decimalPlaces)
			: base("Percent")
		{
			this.FormatString = decimalPlaces.ToString();
		}
	}
}

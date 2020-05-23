// ***
// *** Copyright(C) 2014-2020, Daniel M. Porrey. All rights reserved.
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
using System.Collections.Generic;

namespace Mvc.RazorTools.Charts
{
	/// <summary>
	/// Represents a razor donut chart.
	/// </summary>
	public interface IRazorDonutChart : IRazorChart
	{
		/// <summary>
		/// Gets/sets the background color of the chart.
		/// </summary>
		string BackgroundColor { get; set; }

		/// <summary>
		/// An array of strings containing HTML-style hex colors for each of the donut 
		/// segments. Note: if there are fewer colors than segments, the colors will 
		/// cycle back to the start of the array when exhausted. 
		/// </summary>
		IEnumerable<string> Colors { get; set; }

		/// <summary>
		/// Gets/sets a callback format that will translate a y-value into a label for the center of the donut.
		/// </summary>
		CallbackFormatter Formatter { get; set; }

		/// <summary>
		/// Gets/sets the color of the label in the center of the chart.
		/// </summary>
		string LabelColor { get; set; }
	}
}
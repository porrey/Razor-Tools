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

namespace Mvc.RazorTools.Charts
{
	/// <summary>
	/// Represents a Morris bar chart. 
	/// </summary>
	public interface IRazorBarChart : IRazorSeriesChart
	{
		/// <summary>
		/// Array containing colors for the series bars. 
		/// </summary>
		IEnumerable<string> BarColors { get; set; }

		/// <summary>
		/// Set to true to draw bars stacked vertically. 
		/// </summary>
		bool? Stacked { get; set; }
	}
}
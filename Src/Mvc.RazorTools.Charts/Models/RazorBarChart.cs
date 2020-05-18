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
using System.Collections.Generic;

namespace Mvc.RazorTools.Charts
{
	/// <summary>
	/// Create Morris bar charts. 
	/// </summary>
	public class RazorBarChart : RazorSeriesChart
	{
		private IEnumerable<string> _barColors = null;
		private bool? _stacked = null;

		/// <summary>
		/// Creates an instance of a Morris Bar Chart with the specified ID.
		/// </summary>
		/// <param name="id">The Unique ID of this chart.</param>
		public RazorBarChart(string id)
			: base(id, RazorChartType.Bar)
		{
			this.HtmlTag = "div";
			this.IncludeIdInHtml = true;
		}

		/// <summary>
		/// Array containing colors for the series bars. 
		/// </summary>
		public IEnumerable<string> BarColors
		{
			get
			{
				return _barColors;
			}
			set
			{
				_barColors = value;
				this.SetAttribute("barColors", value);
			}
		}

		/// <summary>
		/// Set to true to draw bars stacked vertically. 
		/// </summary>
		public bool? Stacked
		{
			get
			{
				return _stacked;
			}
			set
			{
				_stacked = value;
				this.SetAttribute("stacked", value.HasValue && value.Value ? value : null);
			}
		}
	}
}

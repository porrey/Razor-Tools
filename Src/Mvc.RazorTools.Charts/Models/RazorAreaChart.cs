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
namespace Mvc.RazorTools.Charts
{
	/// <summary>
	/// Represents a Morris Area chart. Area charts take all the same options as
	/// line charts but are shaded under the lines.
	/// </summary>
	public class RazorAreaChart : RazorLineChart, IRazorAreaChart
	{
		private bool _behaveLikeLine = false;

		/// <summary>
		/// Creates an instance of a Morris Area.
		/// </summary>
		public RazorAreaChart()
			: base(RazorChartType.Area)
		{
			this.HtmlTag = "div";
			this.IncludeIdInHtml = true;
		}

		/// <summary>
		/// Creates an instance of a Morris Area with the specified ID.
		/// </summary>
		/// <param name="id"></param>
		public RazorAreaChart(string id)
			: base(id, RazorChartType.Area)
		{
			this.HtmlTag = "div";
			this.IncludeIdInHtml = true;
		}

		/// <summary>
		/// Gets/sets a value that determines if the items are overlaid on top of each other (true)
		/// instead of stacking them (false).
		/// </summary>
		public bool BehaveLikeLine
		{
			get
			{
				return _behaveLikeLine;
			}
			set
			{
				_behaveLikeLine = value;
				this.UpdateAttribute("data-chart-behaveLikeLine", _behaveLikeLine ? "true" : "false");
			}
		}
	}
}

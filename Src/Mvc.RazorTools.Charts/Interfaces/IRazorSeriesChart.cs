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
	/// 
	/// </summary>
	public interface IRazorSeriesChart : IRazorChart
	{
		/// <summary>
		/// Set to false to disable drawing the x and y axis. 
		/// </summary>
		bool? Axis { get; set; }

		/// <summary>
		/// Set to false to disable drawing the horizontal grid lines.
		/// </summary>
		bool? Grid { get; set; }

		/// <summary>
		/// Set the color of the axis labels (default: #888).
		/// </summary>
		string GridTextColor { get; set; }

		/// <summary>
		/// Set the font family of the axis labels (default: sans-serif). 
		/// </summary>
		string GridTextFamily { get; set; }

		/// <summary>
		/// Set the point size of the axis labels (default: 12).
		/// </summary>
		int? GridTextSize { get; set; }

		/// <summary>
		/// Set the font weight of the axis labels (default: normal).
		/// </summary>
		string GridTextWeight { get; set; }

		/// <summary>
		/// Set to 'False' to always show a hover legend. Set to 'True' or 'Auto' to only show the hover 
		/// legend when the mouse cursor is over the chart. Set to 'Always' to never show a hover legend. 
		/// </summary>
		ChartHoverState HideHover { get; set; }

		/// <summary>
		/// A list of strings containing labels for the data series to be plotted (corresponding to the 
		/// values in the YKeys option). 
		/// </summary>
		IEnumerable<string> Labels { get; set; }

		/// <summary>
		/// A string containing the name of the attribute that contains date (X) values. Timestamps 
		/// are accepted in the form of millisecond timestamps (as returned by Date.getTime() or as 
		/// strings in the following formats:
		/// •2012
		/// •2012 Q1
		/// •2012 W1
		/// •2012-02
		/// •2012-02-24
		/// •2012-02-24 15:00
		/// •2012-02-24 15:00:00
		/// •2012-02-24 15:00:00.000
		/// Note: when using millisecond timestamps, it's recommended that you check out the dateFormat option. 
		/// Note 2: date/time strings can optionally contain a T between the date and time parts, and/or a Z 
		/// suffix, for compatibility with ISO-8601 dates. 
		/// </summary>
		string XKey { get; set; }

		/// <summary>
		/// A list of strings containing names of attributes that contain Y values (one for each series of 
		/// data to be plotted).
		/// </summary>
		IEnumerable<string> YKeys { get; set; }
	}
}
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
	/// Represents a Morris Line chart.
	/// </summary>
	public interface IRazorLineChart : IRazorSeriesChart
	{
		/// <summary>
		/// When set to false (the default), all null and undefined values in a data series will be ignored and lines 
		/// will be drawn spanning them. When set to true, null values will break the line and undefined values will 
		/// be spanned. Note: in v0.5.0, this setting will be removed and the behavior will be to break lines at 
		/// null values. 
		/// </summary>
		bool? ContinuousLine { get; set; }

		/// <summary>
		/// A callback formatter that accepts formats dates for display as chart labels.
		/// </summary>
		CallbackFormatter DateFormat { get; set; }

		/// <summary>
		/// Array of color values to use for the event line colors. If you list fewer colors here than you 
		/// have lines in events, then the values will be cycled. 
		/// </summary>
		IEnumerable<string> EventLineColors { get; set; }

		/// <summary>
		/// A list of x-values to draw as vertical 'event' lines on the chart.
		/// </summary>
		IEnumerable<float> Events { get; set; }

		/// <summary>
		/// Width, in pixels, of the event lines.
		/// </summary>
		int? EventStrokeWidth { get; set; }

		/// <summary>
		/// Change the opacity of the area fill color. Accepts values between 0.0 (for 
		/// completely transparent) and 1.0 (for completely opaque). 
		/// </summary>
		double? FillOpacity { get; set; }

		/// <summary>
		/// Array of color values to use for the goal line colors. If you list fewer colors here than you 
		/// have lines in goals, then the values will be cycled.
		/// </summary>
		IEnumerable<string> GoalLineColors { get; set; }

		/// <summary>
		/// A list of y-values to draw as horizontal 'goal' lines on the chart. 
		/// </summary>
		IEnumerable<float> Goals { get; set; }

		/// <summary>
		/// Width, in pixels, of the goal lines. 
		/// </summary>
		int? GoalStrokeWidth { get; set; }

		/// <summary>
		/// Array containing colors for the series lines/points.
		/// </summary>
		IEnumerable<string> LineColors { get; set; }

		/// <summary>
		/// Width of the series lines, in pixels.
		/// </summary>
		int? LineWidth { get; set; }

		/// <summary>
		/// Set to false to skip time/date parsing for X values, instead treating them as an equally-spaced series. 
		/// </summary>
		bool? ParseTime { get; set; }

		/// <summary>
		/// Colors for the series points. By default uses the same values as LineColors.
		/// </summary>
		IEnumerable<string> PointFillColors { get; set; }

		/// <summary>
		/// Diameter of the series points, in pixels.
		/// </summary>
		int? PointSize { get; set; }

		/// <summary>
		/// Colors for the outlines of the series points. (#ffffff by default).
		/// </summary>
		IEnumerable<string> PointStrokeColors { get; set; }

		/// <summary>
		/// Set to a string value (eg: '%') to add a label suffix all y-labels. 
		/// </summary>
		string PostUnits { get; set; }

		/// <summary>
		/// Set to a string value (eg: '$') to add a label prefix all y-labels. 
		/// </summary>
		string PreUnits { get; set; }

		/// <summary>
		/// Gets/sets a value enable or disable line smoothing. 
		/// </summary>
		bool? LineSmoothing { get; set; }

		/// <summary>
		/// A format callback that accepts date objects and formats them for display as x-axis labels. Overrides the 
		/// default formatter chosen by the automatic labeler or the xLabels option. 
		/// </summary>
		CallbackFormatter XLabelFormat { get; set; }

		/// <summary>
		/// Specifies the x axis labeling interval. By default the interval will be automatically computed.
		/// </summary>
		xLabel XLabels { get; set; }

		/// <summary>
		/// A format callback that accepts y-values and formats them for display as y-axis labels. 
		/// </summary>
		CallbackFormatter YLabelFormat { get; set; }

		/// <summary>
		/// Maximum bound for Y-values. Alternatively, set this to 'auto' to compute automatically, or 'auto [num]' to 
		/// automatically compute and ensure that the max y-value is at least [num]. 
		/// </summary>
		string Ymax { get; set; }

		/// <summary>
		/// Minimum bound for Y-values. Alternatively, set this to 'auto' to compute automatically, or 'auto [num]' 
		/// to automatically compute and ensure that the min y-value is at most [num]. Hint: you can use this 
		/// to create graphs with false origins. 
		/// </summary>
		string Ymin { get; set; }
	}
}
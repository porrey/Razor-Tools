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
namespace Mvc.RazorTools.Charts
{
	/// <summary>
	/// Base interface for all razor charts.
	/// </summary>
	public interface IRazorChart : IMvcRazorObject
	{
		/// <summary>
		/// Gets/sets the height of the div tag to preserve space for the chart. Set this value to 
		/// null to allow the chart to dynamically size.
		/// </summary>
		string ChartHeight { get; set; }

		/// <summary>
		/// The URL to the data to plot. This is an array of objects, containing x and y attributes 
		/// as described by the XKey and YKeys options. Note: ordering doesn't matter here - you  
		/// can supply the data in whatever order works best for you.
		/// </summary>
		string DataUrl { get; set; }

		/// <summary>
		/// Gets the chart library used by this instance represents.
		/// </summary>
		string Library { get; }

		/// <summary>
		/// Gets the type of chart this instance represents.
		/// </summary>
		RazorChartType Type { get; }

		/// <summary>
		/// Set to true to enable automatic resizing when the containing element resizes (default: false).
		/// This has a significant performance impact, so it is disabled by default.
		/// </summary>
		bool? Resize { get; set; }
	}
}
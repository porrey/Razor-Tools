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
	/// This is the base class for the Morris series based charts (line, area and bar).
	/// </summary>
	public abstract class RazorSeriesChart : RazorChart
	{
		private string _xKey = string.Empty;
		private IEnumerable<string> _yKeys = null;
		private IEnumerable<string> _labels = null;
		private HideHoverState _hideHover = HideHoverState.None;
		//hoverCallback: TO DO
		private bool? _axes = null;
		private bool? _grid = null;
		private string _gridTextColor = null;
		private int? _gridTextSize = null;
		private string _gridTextFamily = null;
		private string _gridTextWeight = null;

		/// <summary>
		/// Creates an instance of a Series Chart with
		/// the specified ID.
		/// </summary>
		/// <param name="id">The Unique ID of this chart.</param>
		/// <param name="chartType">The type of chart to create.</param>
		public RazorSeriesChart(string id, RazorChartType chartType)
			: base(id, chartType)
		{
			this.HtmlTag = "div";
			this.IncludeIdInHtml = true;
		}

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
		public virtual string XKey
		{
			get
			{
				return _xKey;
			}
			set
			{
				_xKey = value;
				this.SetAttribute("xkey", value);
			}
		}

		/// <summary>
		/// A list of strings containing names of attributes that contain Y values (one for each series of 
		/// data to be plotted).
		/// </summary>
		public virtual IEnumerable<string> YKeys
		{
			get
			{
				return _yKeys;
			}
			set
			{
				_yKeys = value;
				this.SetAttribute("yKeys", value);
			}
		}

		/// <summary>
		/// A list of strings containing labels for the data series to be plotted (corresponding to the 
		/// values in the YKeys option). 
		/// </summary>
		public virtual IEnumerable<string> Labels
		{
			get
			{
				return _labels;
			}
			set
			{
				_labels = value;
				this.SetAttribute("labels", value);
			}
		}

		/// <summary>
		/// Set to 'False' to always show a hover legend. Set to 'True' or 'Auto' to only show the hover 
		/// legend when the mouse cursor is over the chart. Set to 'Always' to never show a hover legend. 
		/// </summary>
		public HideHoverState HideHover
		{
			get
			{
				return _hideHover;
			}
			set
			{
				_hideHover = value;

				if (value == HideHoverState.None)
				{
					this.SetAttribute("hideHover", null);
				}
				else
				{
					this.SetAttribute("hideHover", value.ToString().ToLower());
				}
			}
		}

		/// <summary>
		/// Set to false to disable drawing the x and y axes. 
		/// </summary>
		public bool? Axes
		{
			get
			{
				return _axes;
			}
			set
			{
				_axes = value;
				this.SetAttribute("axes", value);
			}
		}

		/// <summary>
		/// Set to false to disable drawing the horizontal grid lines.
		/// </summary>
		public bool? Grid
		{
			get
			{
				return _grid;
			}
			set
			{
				_grid = value;
				this.SetAttribute("grid", value);
			}
		}

		/// <summary>
		/// Set the color of the axis labels (default: #888).
		/// </summary>
		public string GridTextColor
		{
			get
			{
				return _gridTextColor;
			}
			set
			{
				_gridTextColor = value;
				this.SetAttribute("gridTextColor", value);
			}
		}

		/// <summary>
		/// Set the point size of the axis labels (default: 12).
		/// </summary>
		public int? GridTextSize
		{
			get
			{
				return _gridTextSize;
			}
			set
			{
				_gridTextSize = value;
				this.SetAttribute("gridTextSize", value);
			}
		}

		/// <summary>
		/// Set the font family of the axis labels (default: sans-serif). 
		/// </summary>
		public string GridTextFamily
		{
			get
			{
				return _gridTextFamily;
			}
			set
			{
				_gridTextFamily = value;
				this.SetAttribute("gridTextFamily", value);
			}
		}

		/// <summary>
		/// Set the font weight of the axis labels (default: normal).
		/// </summary>
		public string GridTextWeight
		{
			get
			{
				return _gridTextWeight;
			}
			set
			{
				_gridTextWeight = value;
				this.SetAttribute("gridTextWeight", value);
			}
		}
	}
}

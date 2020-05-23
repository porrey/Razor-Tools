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
	public class RazorLineChart : RazorSeriesChart, IRazorLineChart
	{
		private IEnumerable<string> _lineColors = null;
		private int? _lineWidth = null;
		private int? _pointSize = null;
		private IEnumerable<string> _pointFillColors = null;
		private IEnumerable<string> _pointStrokeColors = null;
		private string _ymax = null;
		private string _ymin = null;
		private bool? _smooth = null;
		private bool? _parseTime = null;
		private string _postUnits = null;
		private string _preUnits = null;
		private CallbackFormatter _dateFormat = null;
		private xLabel _xLabels = null;
		private CallbackFormatter _xLabelFormat = null;
		private CallbackFormatter _yLabelFormat = null;
		private IEnumerable<float> _goals = null;
		private int? _goalStrokeWidth = 1;
		private IEnumerable<string> _goalLineColors = null;
		private IEnumerable<float> _events = null;
		private int? _eventStrokeWidth = 1;
		private IEnumerable<string> _eventLineColors = null;
		private bool? _continuousLine = null;
		private double? _fillOpacity = 1.0;

		/// <summary>
		/// Creates an instance of a Morris Line Chart.
		/// </summary>
		public RazorLineChart()
			: base(RazorChartType.Line)
		{
			this.HtmlTag = "div";
			this.IncludeIdInHtml = true;
		}

		/// <summary>
		/// Creates an instance of a Morris Line Chart with
		/// the specified ID.
		/// </summary>
		/// <param name="id">The Unique ID of this chart.</param>
		public RazorLineChart(string id)
			: base(id, RazorChartType.Line)
		{
			this.HtmlTag = "div";
			this.IncludeIdInHtml = true;
		}

		internal RazorLineChart(string id, RazorChartType chartType)
			: base(id, chartType)
		{
			this.HtmlTag = "div";
			this.IncludeIdInHtml = true;
		}

		internal RazorLineChart(RazorChartType chartType)
			: base(chartType)
		{
			this.HtmlTag = "div";
			this.IncludeIdInHtml = true;
		}

		/// <summary>
		/// Array containing colors for the series lines/points.
		/// </summary>
		public IEnumerable<string> LineColors
		{
			get
			{
				return _lineColors;
			}
			set
			{
				_lineColors = value;
				this.SetAttribute("lineColors", value);
			}
		}

		/// <summary>
		/// Width of the series lines, in pixels.
		/// </summary>
		public int? LineWidth
		{
			get
			{
				return _lineWidth;
			}
			set
			{
				_lineWidth = value;
				this.SetAttribute("lineWidth", value);
			}
		}

		/// <summary>
		/// Colors for the series points. By default uses the same values as LineColors.
		/// </summary>
		public IEnumerable<string> PointFillColors
		{
			get
			{
				return _pointFillColors;
			}
			set
			{
				_pointFillColors = value;
				this.SetAttribute("pointFillColors", value);
			}
		}

		/// <summary>
		/// Diameter of the series points, in pixels.
		/// </summary>
		public int? PointSize
		{
			get
			{
				return _pointSize;
			}
			set
			{
				_pointSize = value;
				this.SetAttribute("pointSize", value);
			}
		}

		/// <summary>
		/// Colors for the outlines of the series points. (#ffffff by default).
		/// </summary>
		public IEnumerable<string> PointStrokeColors
		{
			get
			{
				return _pointStrokeColors;
			}
			set
			{
				_pointStrokeColors = value;
				this.SetAttribute("pointStrokeColors", value);
			}
		}

		/// <summary>
		/// Max. bound for Y-values. Alternatively, set this to 'auto' to compute automatically, or 'auto [num]' to 
		/// automatically compute and ensure that the max y-value is at least [num]. 
		/// </summary>
		public string Ymax
		{
			get
			{
				return _ymax;
			}
			set
			{
				_ymax = value;
				this.SetAttribute("ymax", value);
			}
		}

		/// <summary>
		/// Min. bound for Y-values. Alternatively, set this to 'auto' to compute automatically, or 'auto [num]' 
		/// to automatically compute and ensure that the min y-value is at most [num]. Hint: you can use this 
		/// to create graphs with false origins. 
		/// </summary>
		public string Ymin
		{
			get
			{
				return _ymin;
			}
			set
			{
				_ymin = value;
				this.SetAttribute("ymin", value);
			}
		}

		/// <summary>
		/// Gets/sets a value enable or disable line smoothing. 
		/// </summary>
		public bool? LineSmoothing
		{
			get
			{
				return _smooth;
			}
			set
			{
				_smooth = value;
				this.SetAttribute("smooth", value);
			}
		}

		/// <summary>
		/// Set to false to skip time/date parsing for X values, instead treating them as an equally-spaced series. 
		/// </summary>
		public bool? ParseTime
		{
			get
			{
				return _parseTime;
			}
			set
			{
				_parseTime = value;
				this.SetAttribute("parseTime", value);
			}
		}

		/// <summary>
		/// Set to a string value (eg: '%') to add a label suffix all y-labels. 
		/// </summary>
		public string PostUnits
		{
			get
			{
				return _postUnits;
			}
			set
			{
				_postUnits = value;
				this.SetAttribute("postUnits", value);
			}
		}

		/// <summary>
		/// Set to a string value (eg: '$') to add a label prefix all y-labels. 
		/// </summary>
		public string PreUnits
		{
			get
			{
				return _preUnits;
			}
			set
			{
				_preUnits = value;
				this.SetAttribute("preUnits", value);
			}
		}

		/// <summary>
		/// A format string that accepts millisecond timestamps and formats them for display as chart labels.
		/// </summary>
		public CallbackFormatter DateFormat
		{
			get
			{
				return _dateFormat;
			}
			set
			{
				_dateFormat = value;
				this.SetAttribute("dateFormat", value);
			}
		}

		/// <summary>
		/// Specifies the x axis labeling interval. By default the interval will be automatically computed.
		/// </summary>
		public xLabel XLabels
		{
			get
			{
				return _xLabels;
			}
			set
			{
				_xLabels = value;
				this.SetAttribute("xLabels", value.Value);
			}
		}

		/// <summary>
		/// A format string that accepts Date objects and formats them for display as x-axis labels. Overrides the 
		/// default formatter chosen by the automatic labeler or the xLabels option. 
		/// </summary>
		public CallbackFormatter XLabelFormat
		{
			get
			{
				return _xLabelFormat;
			}
			set
			{
				_xLabelFormat = value;
				this.SetAttribute("xLabelFormat", value);
			}
		}

		/// <summary>
		/// A string format that accepts y-values and formats them for display as y-axis labels. 
		/// </summary>
		public CallbackFormatter YLabelFormat
		{
			get
			{
				return _yLabelFormat;
			}
			set
			{
				_yLabelFormat = value;
				this.SetAttribute("yLabelFormat", value);
			}
		}

		/// <summary>
		/// A list of y-values to draw as horizontal 'goal' lines on the chart. 
		/// </summary>
		public IEnumerable<float> Goals
		{
			get
			{
				return _goals;
			}
			set
			{
				_goals = value;
				this.SetAttribute("goals", value);
			}
		}

		/// <summary>
		/// Width, in pixels, of the goal lines. 
		/// </summary>
		public int? GoalStrokeWidth
		{
			get
			{
				return _goalStrokeWidth;
			}
			set
			{
				_goalStrokeWidth = value;
				this.SetAttribute("goalStrokeWidth", value);
			}
		}

		/// <summary>
		/// Array of color values to use for the goal line colors. If you list fewer colors here than you 
		/// have lines in goals, then the values will be cycled. 
		/// </summary>
		public IEnumerable<string> GoalLineColors
		{
			get
			{
				return _goalLineColors;
			}
			set
			{
				_goalLineColors = value;
				this.SetAttribute("goalLineColors", value);
			}
		}

		/// <summary>
		/// A list of x-values to draw as vertical 'event' lines on the chart.
		/// </summary>
		public IEnumerable<float> Events
		{
			get
			{
				return _events;
			}
			set
			{
				_events = value;
				this.SetAttribute("events", value);
			}
		}

		/// <summary>
		/// Width, in pixels, of the event lines.
		/// </summary>
		public int? EventStrokeWidth
		{
			get
			{
				return _eventStrokeWidth;
			}
			set
			{
				_eventStrokeWidth = value;
				this.SetAttribute("eventStrokeWidth", value);
			}
		}

		/// <summary>
		/// Array of color values to use for the event line colors. If you list fewer colors here than you 
		/// have lines in events, then the values will be cycled. 
		/// </summary>
		public IEnumerable<string> EventLineColors
		{
			get
			{
				return _eventLineColors;
			}
			set
			{
				_eventLineColors = value;
				this.SetAttribute("eventLineColors", value);
			}
		}

		/// <summary>
		/// When set to false (the default), all null and undefined values in a data series will be ignored and lines 
		/// will be drawn spanning them. When set to true, null values will break the line and undefined values will 
		/// be spanned. Note: in v0.5.0, this setting will be removed and the behavior will be to break lines at 
		/// null values. 
		/// </summary>
		public bool? ContinuousLine
		{
			get
			{
				return _continuousLine;
			}
			set
			{
				_continuousLine = value;
				this.SetAttribute("continuousLine", value);
			}
		}

		/// <summary>
		/// Change the opacity of the area fill color. Accepts values between 0.0 (for 
		/// completely transparent) and 1.0 (for completely opaque). 
		/// </summary>
		public double? FillOpacity
		{
			get
			{
				return _fillOpacity;
			}
			set
			{
				_fillOpacity = value;
				this.SetAttribute("fillOpacity", value);
			}
		}
	}
}

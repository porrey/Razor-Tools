using System.Collections.Generic;

namespace Mvc.RazorTools.Charts
{
	/*
		RazorChart
			RazorSeriesChart
				RazorBarChart
				RazorLineChart
					RazorAreaChart
			RazorDonutChart
	*/

	/// <summary>
	/// Extension methods to create charts with fluent API.
	/// </summary>
	public static class Chart
	{
		/// <summary>
		/// Creates a new chart.
		/// </summary>
		/// <typeparam name="TChart">Specify the chart type to create.</typeparam>
		/// <returns>The newly created instance of the chart.</returns>
		public static TChart Create<TChart>()
			where TChart : IRazorChart, new()
		{
			return new TChart();
		}

		#region All Charts
		/// <summary>
		/// Sets the HTML node ID for this chart.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="id"></param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithId<TChart>(this TChart chart, string id)
			where TChart : IRazorChart
		{
			chart.Id = id;
			return chart;
		}

		/// <summary>
		/// Sets the URL used to retrieve data for the chart.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="url"></param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart UsingDataFrom<TChart>(this TChart chart, string url)
			where TChart : IRazorChart
		{
			chart.DataUrl = url;
			return chart;
		}

		/// <summary>
		/// Sets the height of the div tag to preserve space for the chart. Set this value to 
		/// null to allow the chart to dynamically size.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="height">An CSS/HTML compatible string that represents a height.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithHeight<TChart>(this TChart chart, string height)
			where TChart : IRazorChart
		{
			chart.ChartHeight = height;
			return chart;
		}

		/// <summary>
		/// Enable automatic resizing when the containing element resizes (default: false).
		/// This has a significant performance impact, so it is disabled by default.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart AllowResizing<TChart>(this TChart chart)
			where TChart : IRazorChart
		{
			chart.Resize = true;
			return chart;
		}

		/// <summary>
		/// Disables automatic resizing when the containing element resizes.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart PreventResizing<TChart>(this TChart chart)
			where TChart : IRazorChart
		{
			chart.Resize = false;
			return chart;
		}
		#endregion

		#region Series Chart
		/// <summary>
		/// Sets a string containing the name of the attribute that contains date (X) values. Timestamps 
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
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="xkey">The name of the XKey attribute.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithXKey<TChart>(this TChart chart, string xkey)
			where TChart : IRazorSeriesChart
		{
			chart.XKey = xkey;
			return chart;
		}

		/// <summary>
		/// Sets the list of strings containing names of attributes that contain Y values (one for each series of 
		/// data to be plotted).
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="ykeys">A list of Y values.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithYKeys<TChart>(this TChart chart, string[] ykeys)
			where TChart : IRazorSeriesChart
		{
			chart.YKeys = ykeys;
			return chart;
		}

		/// <summary>
		/// Sets the list of strings containing labels for the data series to be plotted (corresponding to the 
		/// values in the YKeys option).
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="labels">A list of label values.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithLabels<TChart>(this TChart chart, string[] labels)
			where TChart : IRazorSeriesChart
		{
			chart.Labels = labels;
			return chart;
		}

		/// <summary>
		/// Set the hover behavior. to 'False' to always show a hover legend. Set to 'True' or 'Auto' to
		/// only show the hover legend when the mouse cursor is over the chart. Set to 'Always' to never
		/// show a hover legend. 
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="hoverState">The hover state to set.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithHoverState<TChart>(this TChart chart, ChartHoverState hoverState)
			where TChart : IRazorSeriesChart
		{
			chart.HideHover = hoverState;
			return chart;
		}

		/// <summary>
		/// Enables drawing the x and y axis.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithAxis<TChart>(this TChart chart)
			where TChart : IRazorSeriesChart
		{
			chart.Axis = true;
			return chart;
		}

		/// <summary>
		/// Disables drawing the x and y axis.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithoutAxis<TChart>(this TChart chart)
			where TChart : IRazorSeriesChart
		{
			chart.Axis = false;
			return chart;
		}

		/// <summary>
		/// Enables drawing the horizontal grid lines.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithGrid<TChart>(this TChart chart)
			where TChart : IRazorSeriesChart
		{
			chart.Grid = true;
			return chart;
		}

		/// <summary>
		/// Disables drawing the horizontal grid lines.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithoutGrid<TChart>(this TChart chart)
			where TChart : IRazorSeriesChart
		{
			chart.Grid = false;
			return chart;
		}

		/// <summary>
		/// Set the point size of the axis labels (default: 12).
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="gridTextSize">The point size of the axis labels.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithGridTextSize<TChart>(this TChart chart, int? gridTextSize)
			where TChart : IRazorSeriesChart
		{
			chart.GridTextSize = gridTextSize;
			return chart;
		}

		/// <summary>
		/// Set the color of the axis labels (default: #888).
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="gridTextColor">An HTML/CSS color.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithGridTextColor<TChart>(this TChart chart, string gridTextColor)
			where TChart : IRazorSeriesChart
		{
			chart.GridTextColor = gridTextColor;
			return chart;
		}

		/// <summary>
		/// Set the font family of the axis labels (default: sans-serif). 
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="gridTextFamily">The font family name.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithGridTextFamily<TChart>(this TChart chart, string gridTextFamily)
			where TChart : IRazorSeriesChart
		{
			chart.GridTextFamily = gridTextFamily;
			return chart;
		}

		/// <summary>
		/// Set the font weight of the axis labels (default: normal).
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="gridTextWeight">An HTML/CSS font weight.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithGridTextWeight<TChart>(this TChart chart, string gridTextWeight)
			where TChart : IRazorSeriesChart
		{
			chart.GridTextWeight = gridTextWeight;
			return chart;
		}
		#endregion

		#region Line Charts
		/// <summary>
		/// Sets the colors for the series lines/points.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="lineColors">Array containing colors for the series lines/points.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithLineColors<TChart>(this TChart chart, IEnumerable<string> lineColors)
			where TChart : IRazorLineChart
		{
			chart.LineColors = lineColors;
			return chart;
		}

		/// <summary>
		/// Sets the width of the series lines, in pixels.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="lineWidth">Width of the series lines, in pixels.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithLineWidth<TChart>(this TChart chart, int? lineWidth)
			where TChart : IRazorLineChart
		{
			chart.LineWidth = lineWidth;
			return chart;
		}

		/// <summary>
		/// Sets the colors for the series points. By default uses the same values as LineColors.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="pointFillColors">An array of colors for the series points</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithPointFillColors<TChart>(this TChart chart, IEnumerable<string> pointFillColors)
			where TChart : IRazorLineChart
		{
			chart.PointFillColors = pointFillColors;
			return chart;
		}

		/// <summary>
		/// Sets the diameter of the series points, in pixels.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="pointSize">An array of diameters.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithPointSize<TChart>(this TChart chart, int? pointSize)
			where TChart : IRazorLineChart
		{
			chart.PointSize = pointSize;
			return chart;
		}

		/// <summary>
		/// Sets the colors for the outlines of the series points (#ffffff by default).
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="pointStrokeColors">An array of HTML/CSS colors.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithPointStrokeColors<TChart>(this TChart chart, IEnumerable<string> pointStrokeColors)
			where TChart : IRazorLineChart
		{
			chart.PointStrokeColors = pointStrokeColors;
			return chart;
		}

		/// <summary>
		/// Sets the, maximum bound for Y-values. Alternatively, set this to 'auto' to compute automatically, 
		/// or 'auto [num]' to automatically compute and ensure that the max y-value is at least [num]. 
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="ymax">The YMax value.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithYmax<TChart>(this TChart chart, string ymax)
			where TChart : IRazorLineChart
		{
			chart.Ymax = ymax;
			return chart;
		}

		/// <summary>
		/// Sets the minimum bound for Y-values. Alternatively, set this to 'auto' to compute automatically,
		/// or 'auto [num]' to automatically compute and ensure that the min y-value is at most [num]. Hint: 
		/// you can use this to create graphs with false origins. 
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="ymin">The YMin value.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithYmin<TChart>(this TChart chart, string ymin)
			where TChart : IRazorLineChart
		{
			chart.Ymin = ymin;
			return chart;
		}

		/// <summary>
		/// Enables line smoothing.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithLineSmoothing<TChart>(this TChart chart)
			where TChart : IRazorLineChart
		{
			chart.LineSmoothing = true;
			return chart;
		}

		/// <summary>
		/// Disables line smoothing.  
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithoutLineSmoothing<TChart>(this TChart chart)
			where TChart : IRazorLineChart
		{
			chart.LineSmoothing = false;
			return chart;
		}

		/// <summary>
		/// Enables time/date parsing for X values.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithParseTime<TChart>(this TChart chart)
			where TChart : IRazorLineChart
		{
			chart.ParseTime = true;
			return chart;
		}

		/// <summary>
		/// Skips time/date parsing for X values, instead treating them as an equally-spaced series.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithoutParseTime<TChart>(this TChart chart)
			where TChart : IRazorLineChart
		{
			chart.ParseTime = false;
			return chart;
		}

		/// <summary>
		/// Sets a string value (eg: '%') to be appended to all y-labels.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="postUnits">A value to add after all units on the Y axis.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithPostUnits<TChart>(this TChart chart, string postUnits)
			where TChart : IRazorLineChart
		{
			chart.PostUnits = postUnits;
			return chart;
		}

		/// <summary>
		/// Sets a string value (eg: '$') to prefix all y-labels.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="preUnits">The value to be prefixed to all units on the Y axis.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithPreUnits<TChart>(this TChart chart, string preUnits)
			where TChart : IRazorLineChart
		{
			chart.PreUnits = preUnits;
			return chart;
		}

		/// <summary>
		/// Sets the callback formatter that accepts formats dates for display as chart labels.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="dateFormat">A callback object.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithDateFormat<TChart>(this TChart chart, CallbackFormatter dateFormat)
			where TChart : IRazorLineChart
		{
			chart.DateFormat = dateFormat;
			return chart;
		}

		/// <summary>
		/// Specifies the x axis labeling interval. By default the interval will be automatically computed.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="xLabels">A xLabel value.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithXLabels<TChart>(this TChart chart, xLabel xLabels)
			where TChart : IRazorLineChart
		{
			chart.XLabels = xLabels;
			return chart;
		}

		/// <summary>
		/// A format callback that accepts date objects and formats them for display as x-axis labels. Overrides the 
		/// default formatter chosen by the automatic labeler or the xLabels option.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="xLabelFormat">A callback object.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithXLabelFormat<TChart>(this TChart chart, CallbackFormatter xLabelFormat)
			where TChart : IRazorLineChart
		{
			chart.XLabelFormat = xLabelFormat;
			return chart;
		}

		/// <summary>
		/// Sets the angle in degrees from horizontal to draw x-axis labels.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="xLabelAngle">The angle in degrees from horizontal.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithXLabelAngle<TChart>(this TChart chart, int? xLabelAngle)
			where TChart : IRazorLineChart
		{
			chart.XLabelAngle = xLabelAngle;
			return chart;
		}
		
		/// <summary>
		/// A format callback that accepts y-values and formats them for display as y-axis labels.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="yLabelFormat">A callback object.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithYLabelFormat<TChart>(this TChart chart, CallbackFormatter yLabelFormat)
			where TChart : IRazorLineChart
		{
			chart.YLabelFormat = yLabelFormat;
			return chart;
		}

		/// <summary>
		/// Sets a list of y-values to draw as horizontal 'goal' lines on the chart.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="goals">An array of Y values used to set the goal lines.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithGoals<TChart>(this TChart chart, IEnumerable<float> goals)
			where TChart : IRazorLineChart
		{
			chart.Goals = goals;
			return chart;
		}

		/// <summary>
		/// Width, in pixels, of the goal lines.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="goalStrokeWidth">The width of the goal lines in pixels.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithGoalStrokeWidth<TChart>(this TChart chart, int? goalStrokeWidth)
			where TChart : IRazorLineChart
		{
			chart.GoalStrokeWidth = goalStrokeWidth;
			return chart;
		}

		/// <summary>
		/// Sets the array of color values to use for the goal line colors. If you list fewer colors here than you 
		/// have goals lines, then the values will be cycled.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="goalLineColors">An array of HTML/CSS colors.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithGoalLineColors<TChart>(this TChart chart, IEnumerable<string> goalLineColors)
			where TChart : IRazorLineChart
		{
			chart.GoalLineColors = goalLineColors;
			return chart;
		}

		/// <summary>
		/// Sets a list of x-values to draw as vertical 'event' lines on the chart.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="events">An array of X values used to set the event lines.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithEvents<TChart>(this TChart chart, IEnumerable<float> events)
			where TChart : IRazorLineChart
		{
			chart.Events = events;
			return chart;
		}

		/// <summary>
		/// Width, in pixels, of the event lines.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="eventStrokeWidth"></param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithEventStrokeWidth<TChart>(this TChart chart, int? eventStrokeWidth)
			where TChart : IRazorLineChart
		{
			chart.EventStrokeWidth = eventStrokeWidth;
			return chart;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="eventLineColors">The width of the event lines in pixels.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithEventLineColors<TChart>(this TChart chart, IEnumerable<string> eventLineColors)
			where TChart : IRazorLineChart
		{
			chart.EventLineColors = eventLineColors;
			return chart;
		}

		/// <summary>
		/// Null values will break the line and undefined values will be spanned. Note: in v0.5.0,
		/// this setting will be removed and the behavior will be to break lines at null values.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithContinuousLine<TChart>(this TChart chart)
			where TChart : IRazorLineChart
		{
			chart.ContinuousLine = true;
			return chart;
		}

		/// <summary>
		/// Null and undefined values in a data series will be ignored and lines will be drawn spanning them.
		/// When set to true, null values will break the line and undefined values will be spanned. Note: 
		/// in v0.5.0, this setting will be removed and the behavior will be to break lines at 
		/// null values.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithoutContinuousLine<TChart>(this TChart chart)
			where TChart : IRazorLineChart
		{
			chart.ContinuousLine = false;
			return chart;
		}

		/// <summary>
		/// Sets the opacity of the area fill color. Accepts values between 0.0 (for 
		/// completely transparent) and 1.0 (for completely opaque).
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="fillOpacity">The opacity value.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithFillOpacity<TChart>(this TChart chart, double? fillOpacity)
			where TChart : IRazorLineChart
		{
			chart.FillOpacity = fillOpacity;
			return chart;
		}
		#endregion

		#region Area Chart
		/// <summary>
		/// Sets items to be overlaid on top of each other.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithLineBehavior<TChart>(this TChart chart)
			where TChart : IRazorAreaChart
		{
			chart.BehaveLikeLine=true;
			return chart;
		}

		/// <summary>
		/// Sets items to be stacked.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithoutLineBehavior<TChart>(this TChart chart)
			where TChart : IRazorAreaChart
		{
			chart.BehaveLikeLine = false;
			return chart;
		}
		#endregion

		#region Bar Charts
		/// <summary>
		/// Sets the colors for the series bars. 
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="barColors">An array of HTML/CSS colors.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithBarColors<TChart>(this TChart chart, IEnumerable<string> barColors)
			where TChart : IRazorBarChart
		{
			chart.BarColors = barColors;
			return chart;
		}

		/// <summary>
		/// Draw bars of multiple series stacked vertically.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart AsStacked<TChart>(this TChart chart)
			where TChart : IRazorBarChart
		{
			chart.Stacked = true;
			return chart;
		}

		/// <summary>
		/// Draw bars of multiple series side by side.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart AsUnstacked<TChart>(this TChart chart)
			where TChart : IRazorBarChart
		{
			chart.Stacked = false;
			return chart;
		}
		#endregion

		#region Donut Charts
		/// <summary>
		/// Sets the colors for each of the donut segments. Note: if
		/// there are fewer colors than segments, the colors will 
		/// cycle back to the start of the array when exhausted. 
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="colors">An array of HTML/CSS colors.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithColors<TChart>(this TChart chart, IEnumerable<string> colors)
			where TChart : IRazorDonutChart
		{
			chart.Colors = colors;
			return chart;
		}

		/// <summary>
		/// Sets a callback format that will translate a y-value into a label for the
		/// center of the donut.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="formatter">A callback object.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithFormatter<TChart>(this TChart chart, CallbackFormatter formatter)
			where TChart : IRazorDonutChart
		{
			chart.Formatter = formatter;
			return chart;
		}

		/// <summary>
		/// Sets the background color of the chart.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="backgroundColor">An HTML/CSS color.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithBackgroundColor<TChart>(this TChart chart, string backgroundColor)
			where TChart : IRazorDonutChart
		{
			chart.BackgroundColor = backgroundColor;
			return chart;
		}

		/// <summary>
		/// Sets the color of the label in the center of the chart.
		/// </summary>
		/// <typeparam name="TChart">The chart Type.</typeparam>
		/// <param name="chart">An instance of a chart.</param>
		/// <param name="labelColor">An HTML/CSS color.</param>
		/// <returns>An updated instance of the chart.</returns>
		public static TChart WithLabelColor<TChart>(this TChart chart, string labelColor)
			where TChart : IRazorDonutChart
		{
			chart.LabelColor = labelColor;
			return chart;
		}
		#endregion
	}
}

using System.Collections.Generic;

namespace Mvc.RazorTools.Charts
{
	/// <summary>
	/// A razor donut chart.
	/// </summary>
	public class RazorDonutChart : RazorChart
	{
		private IEnumerable<string> _colors = null;
		private CallbackFormatter _formatter = null;
		private string _backgroundColor = null;
		private string _labelColor = null;

		/// <summary>
		/// Creates a new instance of a Morris Donut Chart with
		/// the specified ID.
		/// </summary>
		/// <param name="id">The Unique ID of this chart.</param>
		public RazorDonutChart(string id)
			: base(id, RazorChartType.Donut)
		{
			this.HtmlTag = "div";
			this.IncludeIdInHtml = true;
		}

		/// <summary>
		/// An array of strings containing HTML-style hex colors for each of the donut 
		/// segments.  Note: if there are fewer colors than segments, the colors will 
		/// cycle back to the start of the array when exhausted. 
		/// </summary>
		public IEnumerable<string> Colors
		{
			get
			{
				return _colors;
			}
			set
			{
				_colors = value;
				this.SetAttribute("colors", value);
			}
		}

		/// <summary>
		/// A string format that will translate a y-value into a label for the center of the donut. 
		/// </summary>
		public CallbackFormatter Formatter
		{
			get
			{
				return _formatter;
			}
			set
			{
				_formatter = value;
				this.SetAttribute("formatter", value);
			}
		}

		/// <summary>
		/// Gets/sets the background color of the chart.
		/// </summary>
		public string BackgroundColor
		{
			get
			{
				return _backgroundColor;
			}
			set
			{
				_backgroundColor = value;
				this.SetAttribute("backgroundColor", value);
			}
		}

		/// <summary>
		/// Gets/sets the color of the label in the center of the chart.
		/// </summary>
		public string LabelColor
		{
			get
			{
				return _labelColor;
			}
			set
			{
				_labelColor = value;
				this.SetAttribute("labelColor", value);
			}
		}
	}
}

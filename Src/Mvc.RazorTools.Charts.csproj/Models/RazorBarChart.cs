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

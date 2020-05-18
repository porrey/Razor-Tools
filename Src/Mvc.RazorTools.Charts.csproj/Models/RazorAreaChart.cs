namespace Mvc.RazorTools.Charts
{
	/// <summary>
	/// Creates Morris Area charts. Area charts take all the same options as line charts but are shaded
	/// under the lines.
	/// </summary>
	public class RazorAreaChart : RazorLineChart
	{
		private bool _behaveLikeLine = false;

		/// <summary>
		/// Creates an instance of <see cref="RazorAreaChart"/> with the specified ID.
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

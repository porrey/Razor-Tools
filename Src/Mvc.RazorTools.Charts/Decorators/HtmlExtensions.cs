using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Mvc.RazorTools.Charts
{
	/// <summary>
	/// Provides a set of extension methods for the <see cref="IHtmlHelper"/> interface. These extension
	/// methods are referenced in the razor view using the @Html keyword.
	/// </summary>
	public static class HtmlExtensions
	{
		/// <summary>
		/// Extension method to display a Razor Chart in a view.
		/// </summary>
		/// <param name="html">An instance of <see cref="IHtmlHelper"/>.</param>
		/// <param name="chart">An instance of the chart to display.</param>
		/// <returns></returns>
		public static IHtmlContent MorrisChart(this IHtmlHelper html, RazorChart chart)
		{
			return chart.Html;
		}

		/// <summary>
		/// Extension method to display a Razor Chart in a view.
		/// </summary>
		/// <param name="html">An instance of <see cref="IHtmlHelper"/>.</param>
		/// <param name="chart">An instance of the chart to display.</param>
		/// <returns></returns>
		public static IHtmlContent RenderChart(this IHtmlHelper html, RazorChart chart)
		{
			return chart.Html;
		}
	}
}

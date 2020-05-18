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

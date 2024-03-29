﻿//
// Copyright(C) 2014-2020, Daniel M. Porrey. All rights reserved.
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published
// by the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program. If not, see http://www.gnu.org/licenses/.
//
namespace Mvc.RazorTools.Charts
{
	/// <summary>
	/// This is the base class for all Morris charts.
	/// </summary>
	public enum RazorChartType
	{
		/// <summary>
		/// The type of chart is not specified.
		/// </summary>
		None,
		/// <summary>
		/// An Area Chart with lines, points and shaded area under the lines.
		/// </summary>
		Area,
		/// <summary>
		/// An Line Chart with lines and points.
		/// </summary>
		Line,
		/// <summary>
		/// A circular graph with slices representing the data.
		/// </summary>
		Donut,
		/// <summary>
		/// A vertical bar chart.
		/// </summary>
		Bar
	}
}

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
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mvc.RazorTools.Charts
{
	/// <summary>
	/// Abstract class for all razor charts.
	/// </summary>
	public abstract class RazorChart : RazorToolsObject, IRazorChart
	{
		/// <summary>
		/// Creates a new instance of a razor chart.
		/// </summary>
		/// <param name="chartType">The type of chart to create.</param>
		public RazorChart(RazorChartType chartType)
			: base()
		{
			this.HtmlTag = "div";
			this.IncludeIdInHtml = true;
			this.Type = chartType;
			this.Library = "morris";
		}

		/// <summary>
		/// Creates a new instance of a razor chart of the given type with the specified
		/// ID.
		/// </summary>
		/// <param name="id">The Unique ID of this chart.</param>
		/// <param name="chartType">The type of chart to create.</param>
		public RazorChart(string id, RazorChartType chartType)
			: base(id)
		{
			this.HtmlTag = "div";
			this.IncludeIdInHtml = true;
			this.Type = chartType;
			this.Library = "morris";
		}

		private string _library = null;
		/// <summary>
		/// Gets the chart library used by this instance represents.
		/// </summary>
		public virtual string Library
		{
			get
			{
				return _library;
			}
			internal set
			{
				_library = value;
				this.SetAttribute("library", value.ToLower());
			}
		}

		private RazorChartType _type = RazorChartType.None;
		/// <summary>
		/// Gets the type of chart this instance represents.
		/// </summary>
		public virtual RazorChartType Type
		{
			get
			{
				return _type;
			}
			internal set
			{
				_type = value;
				this.SetAttribute("type", value.ToString().ToLower());
			}
		}

		private string _dataUrl = null;
		/// <summary>
		/// The URL to the data to plot. This is an array of objects, containing x and y attributes 
		/// as described by the XKey and YKeys options. Note: ordering doesn't matter here - you  
		/// can supply the data in whatever order works best for you.
		/// </summary>
		public virtual string DataUrl
		{
			get
			{
				return _dataUrl;
			}
			set
			{
				_dataUrl = value;
				this.SetAttribute("dataUrl", value);
			}
		}

		private string _chartHeight = null;
		/// <summary>
		/// Gets/sets the height of the div tag to preserve space for the chart. Set this value to 
		/// null to allow the chart to dynamically size.
		/// </summary>
		public string ChartHeight
		{
			get
			{
				return _chartHeight;
			}
			set
			{
				_chartHeight = value;
				this.SetStyle("height", value);
			}
		}

		private bool? _resize = null;
		/// <summary>
		/// Set to true to enable automatic resizing when the containing element resizes (default: false).
		/// This has a significant performance impact, so it is disabled by default.
		/// </summary>
		public bool? Resize
		{
			get
			{
				return _resize;
			}
			set
			{
				_resize = value;
				this.SetAttribute("resize", value);
			}
		}

		/// <summary>
		/// Sets or removes the attribute and value.
		/// </summary>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="value">The value of the attribute. A null value will remove the attribute.</param>
		protected virtual void SetAttribute(string name, object value)
		{
			string attributeName = String.Format("data-chart-{0}", name);

			if (value == null)
			{
				// ***
				// *** If the value is null and the attribute exists
				// *** then remove it.
				// ***
				if (this.Attributes.ContainsKey(attributeName))
				{
					this.Attributes.Remove(attributeName);
				}
			}
			else
			{
				if (value is bool)
				{
					this.UpdateAttribute(attributeName, (bool)value ? "true" : "false");
				}
				else if (value is IEnumerable<string>)
				{
					string[] items = ((IEnumerable<string>)value).ToArray();
					this.UpdateAttribute(attributeName, string.Join(",", items));
				}
				else if (value is IEnumerable<float>)
				{
					float[] items = ((IEnumerable<float>)value).ToArray();
					this.UpdateAttribute(attributeName, string.Join(",", items));
				}
				else if (value is CallbackFormatter)
				{
					this.UpdateAttribute(attributeName, ((CallbackFormatter)value).AttributeValue);
				}
				else
				{
					this.UpdateAttribute(attributeName, Convert.ToString(value));
				}
			}
		}

		/// <summary>
		/// Sets or removes the style and value.
		/// </summary>
		/// <param name="name">The name of the style.</param>
		/// <param name="value">The value of the style. A null value will remove the style.</param>
		protected virtual void SetStyle(string name, string value)
		{
			if (value == null)
			{
				// ***
				// *** If the value is null and the attribute exists
				// *** then remove it.
				// ***
				if (this.Styles.ContainsKey(name))
				{
					this.Styles.Remove(name);
				}
			}
			else
			{
				this.UpdateStyle(name, value);
			}
		}
	}
}

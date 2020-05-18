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
namespace Mvc.RazorTools.Charts
{
	/// <summary>
	/// Specifies the x axis labeling interval. By default the interval will be automatically computed. 
	/// The following are valid interval strings: 
	/// </summary>
	public class xLabel
	{
		/// <summary>
		/// Gets/sets the string value expected by the Morris.js library.
		/// </summary>
		public string Value { get; set; }

		/// <summary>
		/// Specifies the X-Axis label interval will be one decade.
		/// </summary>
		public static xLabel Decade = new xLabel() { Value = "decade" };

		/// <summary>
		/// Specifies the X-Axis label interval will be one year.
		/// </summary>
		public static xLabel Year = new xLabel() { Value = "year" };

		/// <summary>
		/// Specifies the X-Axis label interval will be one month.
		/// </summary>
		public static xLabel Month = new xLabel() { Value = "month" };

		/// <summary>
		/// Specifies the X-Axis label interval will be one day.
		/// </summary>
		public static xLabel Day = new xLabel() { Value = "day" };

		/// <summary>
		/// Specifies the X-Axis label interval will be an hour.
		/// </summary>
		public static xLabel Hour = new xLabel() { Value = "hour" };

		/// <summary>
		/// Specifies the X-Axis label interval will be 30 minutes.
		/// </summary>
		public static xLabel ThirtyMinute = new xLabel() { Value = "30min" };
		
		/// <summary>
		/// Specifies the X-Axis label interval will be 15 minutes.
		/// </summary>
		public static xLabel FifteenMinute = new xLabel() { Value = "15min" };

		/// <summary>
		/// Specifies the X-Axis label interval will be 10 minutes.
		/// </summary>
		public static xLabel TenMinute = new xLabel() { Value = "10min" };

		/// <summary>
		/// Specifies the X-Axis label interval will be 5 minutes.
		/// </summary>
		public static xLabel FiveMinute = new xLabel() { Value = "5min" };

		/// <summary>
		/// Specifies the X-Axis label interval will be one minute.
		/// </summary>
		public static xLabel Minute = new xLabel() { Value = "minute" };

		/// <summary>
		/// Specifies the X-Axis label interval will be 30 seconds.
		/// </summary>
		public static xLabel ThirtySecond = new xLabel() { Value = "30sec" };

		/// <summary>
		/// Specifies the X-Axis label interval will be 15 seconds.
		/// </summary>
		public static xLabel FifteenSecond = new xLabel() { Value = "15sec" };

		/// <summary>
		/// Specifies the X-Axis label interval will be 10 seconds.
		/// </summary>
		public static xLabel TenSeconds = new xLabel() { Value = "10sec" };

		/// <summary>
		/// Specifies the X-Axis label interval will be 5 seconds.
		/// </summary>
		public static xLabel FiveSecond = new xLabel() { Value = "5sec" };

		/// <summary>
		/// Specifies the X-Axis label interval will be one second.
		/// </summary>
		public static xLabel Second = new xLabel() { Value = "second" };
	}
}

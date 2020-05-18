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

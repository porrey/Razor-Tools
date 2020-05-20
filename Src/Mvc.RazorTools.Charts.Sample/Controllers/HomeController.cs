using Microsoft.AspNetCore.Mvc;

namespace Mvc.RazorTools.Charts.Sample.Controllers
{
	public class HomeController : Controller
	{
		public HomeController()
		{
		}

		public IActionResult Index()
		{
			return this.View();
		}

		/// <summary>
		/// 2013 Actual monthly precipitation recorded at Midway Airport with the
		/// record value and 30-year average.
		/// </summary>
		/// <returns></returns>
		public JsonResult MonthlyPrecipitation()
		{
			object data = new object[]
			{
				new {month = "January", avg = 2.06, rec = 6.09, actual = 3.18},
				new {month = "February", avg = 1.94, rec = 6.77, actual = 2.57},
				new {month = "March", avg = 2.72, rec = 5.77, actual = 2.22},
				new {month = "April", avg = 3.64, rec = 7.74, actual = 7.95},
				new {month = "May", avg = 4.13, rec = 7.68, actual = 6.47},
				new {month = "June", avg = 4.06, rec = 9.53, actual = 3.12},
				new {month = "July", avg = 4.01, rec = 10.39, actual = 2.19},
				new {month = "August", avg = 3.99, rec = 9.23, actual = 2.52},
				new {month = "September", avg = 3.31, rec = 11.15, actual = 1.93},
				new {month = "October", avg = 3.24, rec = 11.70, actual = 5.69},
				new {month = "November", avg = 3.42, rec = 8.08, actual = 2.94},
				new {month = "December", avg = 2.57, rec = 7.51, actual = 1.54}
			};

			return this.Json(data);
		}

		/// <summary>
		/// 2013 Running actual monthly precipitation total recorded at Midway Airport.
		/// </summary>
		/// <returns></returns>
		public JsonResult TotalPrecipitation()
		{
			object data = new object[]
			{
				new {month = "2013-01", tot = 3.18},
				new {month = "2013-02", tot = 5.75},
				new {month = "2013-03", tot = 7.97},
				new {month = "2013-04", tot = 15.92},
				new {month = "2013-05", tot = 22.39},
				new {month = "2013-06", tot = 25.51},
				new {month = "2013-07", tot = 27.7},
				new {month = "2013-08", tot = 30.22},
				new {month = "2013-09", tot = 32.15},
				new {month = "2013-10", tot = 37.84},
				new {month = "2013-11", tot = 40.78},
				new {month = "2013-12", tot = 42.32},
			};

			return this.Json(data);
		}

		/// <summary>
		/// 2013 Actual monthly precipitation recorded at Midway Airport compared to
		/// actuals for 2012.
		/// </summary>
		/// <returns></returns>
		public JsonResult ActualPrecipitation()
		{
			object data = new object[]
			{
					new {month = "2013-01", a2103 = 3.18, a2012 = 2.16},
					new {month = "2013-02", a2103 = 2.57, a2012 = 1.39},
					new {month = "2013-03", a2103 = 2.22, a2012 = 2.17},
					new {month = "2013-04", a2103 = 7.95, a2012 = 2.63},
					new {month = "2013-05", a2103 = 6.47, a2012 = 4.32},
					new {month = "2013-06", a2103 = 3.12, a2012 = 1.07},
					new {month = "2013-07", a2103 = 2.19, a2012 = 3.78},
					new {month = "2013-08", a2103 = 2.52, a2012 = 6.06},
					new {month = "2013-09", a2103 = 1.93, a2012 = 1.61},
					new {month = "2013-10", a2103 = 5.69, a2012 = 3.21},
					new {month = "2013-11", a2103 = 2.94, a2012 = 1.04},
					new {month = "2013-12", a2103 = 1.54, a2012 = 2.09},
			};

			return this.Json(data);
		}

		/// <summary>
		/// Average seasonal precipitation.
		/// </summary>
		/// <returns></returns>
		public JsonResult SeasonalPrecipitation()
		{
			object data = new object[]
			{
				new {label = "Spring", value = 10.94},
				new {label = "Summer", value = 12.06},
				new {label = "Fall", value = 9.97},
				new {label = "Winter", value = 6.57}
			};

			return this.Json(data);
		}

		/// <summary>
		/// Total precipitation 2009 through 2013.
		/// </summary>
		/// <returns></returns>
		public JsonResult FiveYearTotals()
		{
			object data = new object[]
			{
				new {label = "2009", value = 46.08},
				new {label = "2010", value = 44.75},
				new {label = "2011", value = 46.62},
				new {label = "2012", value = 31.53},
				new {label = "2013", value = 42.32}
			};

			return this.Json(data);
		}
	}
}

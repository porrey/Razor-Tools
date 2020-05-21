# Razor-Tools
The Razor Tools library is designed to wrap JavaScript and JQuery objects into C# methods. Objects can be easily added to Razor views with basic C# code. All objects are created and initialized using unobtrusive JavaScript techniques and fluent API. This allows complex objects to be created within your views with simple C# statements.

## Mvc.RazorTools.Base
This library provides the base class for all RazorTools objects. It provides the basic code for building tags and embedding them in Razor views. Al of the RazorTools packages will be based on this library. Generally, you will not add this library directly to your project.

## Mvc.RazorTools.Charts
Create simple charts in you Razor views. This library wraps morris.js charts along with some other tools to produce nice looking charts. For more information see the documentation in the repo Wiki pages: https://github.com/porrey/Razor-Tools/wiki/RazorTools-Charts.

### Bar Chart
The sample code below generates a bar chart.

	@Html.RenderChart(new RazorBarChart("monthlyPrecipitation")
	{
		DataUrl = this.Url.Action("MonthlyPrecipitation", "Home"),
		XKey = "month",
		YKeys = new string[] { "avg", "rec", "actual" },
		Labels = new string[] { "Average", "Record", "Actual" },
		GridTextSize = gridTextSize,
		BarColors = colors
	})

The resulting chart is shown below.

![Bar Chart](https://github.com/porrey/Razor-Tools/raw/master/Images/chart-sample-1.png)

### Line Chart
The sample code below generates a line chart.

	@Html.RenderChart(new RazorLineChart("actualPrecipitation")
	{
		DataUrl = this.Url.Action("ActualPrecipitation", "Home"),
		XKey = "month",
		YKeys = new string[] { "a2103", "a2012" },
		Labels = new string[] { "2013", "2012" },
		LineColors = colors,
		DateFormat = new DateFormatter("MMMM"),
		XLabels = xLabel.Month,
		XLabelFormat = new DateFormatter("MMMM"),
		GridTextSize = gridTextSize,
		FillOpactiy = fillOpacity,
		Ymax = "8",
		ChartHeight = "350px"
	})

![Line Chart](https://github.com/porrey/Razor-Tools/raw/master/Images/chart-sample-2.png)

### Donut Chart
The sample code below generates a donut chart.

	@Html.RenderChart(new RazorDonutChart("seasonalPrecipitation")
	{
		DataUrl = this.Url.Action("SeasonalPrecipitation", "Home"),
		Colors = colors,
		Formatter = new AppendFormatter(" in"),
		LabelColor = "#BBBBBB"
	})

![Donut Chart](https://github.com/porrey/Razor-Tools/raw/master/Images/chart-sample-3.png)

### Area Chart
The sample code below generates an area chart.

	@Html.RenderChart(new RazorAreaChart("totalPrecipitation")
	{
		DataUrl = this.Url.Action("TotalPrecipitation", "Home"),
		XKey = "month",
		YKeys = new string[] { "tot" },
		Labels = new string[] { "Year to Date" },
		Smooth = true,
		FillOpactiy = fillOpacity,
		PostUnits = "in",
		GridTextSize = gridTextSize,
		LineColors = colors,
		DateFormat = new DateFormatter("MMMM, YYYY"),
		XLabels = xLabel.Month,
		XLabelFormat = new DateFormatter("MMMM")
	})

![Area Chart](https://github.com/porrey/Razor-Tools/raw/master/Images/chart-sample-4.png)

### Data

In each of the samples above, the chart data is retrieved from a controller action.

The code shown below is called by the bar chart.

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

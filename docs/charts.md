
layout: page
title: "RazorTools - Charts"
permalink: /charts/

## Bar Chart
The sample code below generates a bar chart.
		
	@(Chart.Create<RazorBarChart>()
		.WithId("monthlyPrecipitation1")
		.UsingDataFrom(this.Url.Action("MonthlyPrecipitation", "Home"))
		.WithXKey("month")
		.WithYKeys(new string[] { "avg", "rec", "actual" })
		.WithLabels(new string[] { "Average", "Record", "Actual" })
		.WithGridTextSize(gridTextSize)
		.WithBarColors(colors)
		.WithHoverState(ChartHoverState.Auto)
		.AllowResizing())
The resulting chart is shown below.

![Bar Chart](https://github.com/porrey/Razor-Tools/raw/master/Images/chart-sample-1.png)

## Stacked Bar Chart
The sample code below generates a bar chart.

	@(Chart.Create<RazorBarChart>()
		.WithId("monthlyPrecipitation2")
		.UsingDataFrom(this.Url.Action("MonthlyPrecipitation", "Home"))
		.WithXKey("month")
		.WithYKeys(new string[] { "avg", "rec", "actual" })
		.WithLabels(new string[] { "Average", "Record", "Actual" })
		.WithGridTextSize(gridTextSize)
		.WithBarColors(colors)
		.AsStacked()
		.WithHoverState(ChartHoverState.True)
		.AllowResizing())
The resulting chart is shown below.

![Bar Chart](https://github.com/porrey/Razor-Tools/raw/master/Images/chart-sample-2.png)

## Line Chart
The sample code below generates a line chart.

	@(Chart.Create<RazorLineChart>()
		.WithId("actualPrecipitation")
		.UsingDataFrom(this.Url.Action("ActualPrecipitation", "Home"))
		.WithHeight("350px")
		.WithXKey("month")
		.WithYKeys(new string[] { "a2103", "a2012" })
		.WithLabels ( new string[] { "2013", "2012" })
		.WithXLabelAngle(60)
		.WithDateFormat (new DateFormatter("MMMM"))
		.WithXLabels(xLabel.Month)
		.WithXLabelFormat(new DateFormatter("MMMM"))
		.WithGridTextSize(gridTextSize)
		.WithFillOpacity (fillOpacity)
		.WithYmax ("8")
		.AllowResizing())
The resulting chart is shown below.

![Line Chart](https://github.com/porrey/Razor-Tools/raw/master/Images/chart-sample-3.png)

## Donut Chart 1
The sample code below generates a donut chart.

	@(Chart.Create<RazorDonutChart>()
		.WithId("seasonalPrecipitation")
		.UsingDataFrom(this.Url.Action("SeasonalPrecipitation", "Home"))
		.WithColors(colors)
		.WithFormatter(new AppendFormatter(" in"))
		.WithLabelColor("#BBBBBB")
		.AllowResizing())
The resulting chart is shown below.

![Donut Chart](https://github.com/porrey/Razor-Tools/raw/master/Images/chart-sample-4.png)

## Donut Chart 2
The sample code below generates a slightly different donut chart.

	@(Chart.Create<RazorDonutChart>()
		.WithId("fiveYearTotals")
		.UsingDataFrom(this.Url.Action("FiveYearTotals", "Home"))
		.WithHeight("200px")
		.WithColors(colors)
		.WithFormatter(new AppendFormatter(" in"))
		.WithLabelColor("#BBBBBB")
		.WithBackgroundColor("#353535")
		.AllowResizing()
		.PreventResizing())
The resulting chart is shown below.

![Donut Chart](https://github.com/porrey/Razor-Tools/raw/master/Images/chart-sample-5.png)

## Area Chart
The sample code below generates a bar chart.

	The sample code below generates an area chart.
	@(Chart.Create<RazorAreaChart>()
		.WithId("totalPrecipitation")
		.UsingDataFrom(this.Url.Action("TotalPrecipitation", "Home"))
		.WithXKey("month")
		.WithYKeys(new string[] { "tot" })
		.WithLabels(new string[] { "Year to Date" })
		.WithLineSmoothing()
		.WithFillOpacity(fillOpacity)
		.WithPostUnits("in")
		.WithGridTextSize(gridTextSize)
		.WithLineColors(colors)
		.WithDateFormat(new DateFormatter("MMMM, YYYY"))
		.WithXLabels(xLabel.Month)
		.WithXLabelFormat(new DateFormatter("MMMM"))
		.AllowResizing())
The resulting chart is shown below.

![Area Chart](https://github.com/porrey/Razor-Tools/raw/master/Images/chart-sample-6.png)
## Data
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

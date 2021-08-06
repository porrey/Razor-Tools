/*!
	Razor Tools Unobtrusive Charts version 2.0.0
	Copyright 2013-2020 Daniel M. Porrey
	Licensed under LGPL-3.0
	https://github.com/porrey/Razor-Tools/blob/master/LICENSE
*/

$(function () {
	//
	// Find all charts
	//
	$('div[data-chart-type]').each(function () {
		//
		// Get a reference to the HTML element where
		// the chart is to be created
		//
		var razorChart = new RazorTools.Chart($(this));
	});
});

module RazorTools {
	//
	// Represents a chart created by a div tag
	//
	export class Chart {
		//
		// Constructor 
		//
		constructor(htmlElement: JQuery) {
			this.htmlElement = htmlElement;
			this.create();
		}

		//
		// The jQuery object that represents the div tag
		// defining the chart
		//
		private htmlElement: JQuery
		private chartType: ChartType

		//
		// Loads the chart properties from the div tag
		// and creates the chart.
		//
		private create(): void {
			//
			// Find the chart type for this instance
			//
			if ((this.chartType = ChartType.findChartType(this.htmlElement)) != undefined) {
				var options = this.loadOptions();
				this.chartType.create(this.chartType, options, this.htmlElement, Chart.FailureHtml);
			}
		}

		//
		// Load the chart options
		//
		private loadOptions() {
			//
			// Create an array for the options
			//
			var options = {};

			//
			// Loop through all options, this way any required options
			// that are missing can be detected.
			//
			for (var i = 0; i < ChartOption.AllOptions.length; i++) {
				//
				// Get a reference to the chart option to make the
				// code simpler
				//
				var chartOption = ChartOption.AllOptions[i];

				//
				// Check if this option is required for the current chart type
				//
				if (chartOption.chart.indexOf(this.chartType) >= 0) {
					//
					// Only load those marked as autoLoad = true
					//
					if (chartOption.autoLoad) {
						//
						// Get the value for this attribute.
						//
						var value: string = this.htmlElement.attr(chartOption.attributeName());

						//
						// Check if this attribute has a value
						//
						if (value != undefined) {
							//
							// Convert the string value to the type required by the option.
							//
							if (chartOption.optionType.getValue != undefined) {
								//
								// Get the conversion function and 
								// convert the string value.
								//
								options[chartOption.name] = chartOption.optionType.getValue(value);;
							}
							else {
								//
								// Throw an exception; a conversion function was not defined
								// for this option type.
								//
								jQuery.error('The option type "' + chartOption.optionType.name + '" does not have a conversion function defined.');
							}
						}
						else {
							if (ChartOption.AllOptions[i].isRequired) {
								//
								// Throw an exception since this is a required option; show the
								// option name and not the attributeName.
								//
								jQuery.error('The element "' + chartOption.name + '" is required.');
							}
						}
					}
					else {
						if (this.isDefined(chartOption)) {
							//
							// Throw an exception
							//
							jQuery.error('The chart option "' + chartOption.name + '" is invalid for a "' + this.chartType.name + '" chart.');
						}
					}
				}
			}

			return options;
		}

		//
		// Determines if a specific attribute exists
		// on the HTML element.
		//
		private isDefined(chartOption: ChartOption) {
			//
			// Determine if the element exists
			//
			var value = this.htmlElement.attr(chartOption.attributeName());

			if (value == undefined) {
				return false;
			}
			else {
				return true;
			}
		}

		//
		// This will be displayed if the data load fails
		//
		static FailureHtml: string = '<div class="alert alert-danger">Failed to load data</div>';
	}

	//
	// This class defines the type of charts available
	//
	class ChartType {
		constructor(public name: string, public library: string, public createChart: any) {
		}

		//
		// Loads the data and then creates and displays the chart
		//
		create(chartType: ChartType, options: any, htmlElement: JQuery, failureHtml: string): any {
			var returnValue = undefined;

			$.getJSON(options['dataUrl'], function (json) {
				options['data'] = json;
				returnValue = chartType.createChart(options);
			}).fail(function () {
				htmlElement.html(failureHtml);
			});

			return returnValue;
		}

		//
		// The are the attribute names expected defining the
		// library and the chart
		//
		static LibraryTag: string = "data-chart-library";
		static ChartTag: string = "data-chart-type";

		//
		// This array contains all known chart types
		//
		static AllChartTypes: ChartType[] = [
			new ChartType('area', 'morris', function (options) { return new Morris.Area(options); }),
			new ChartType('line', 'morris', function (options) { return new Morris.Line(options); }),
			new ChartType('bar', 'morris', function (options) { return new Morris.Bar(options); }),
			new ChartType('donut', 'morris', function (options) { return new Morris.Donut(options); })
		];

		//
		// Static definitions to allow charts by name
		//
		static MorrisArea: ChartType = ChartType.AllChartTypes[0];
		static MorrisLine: ChartType = ChartType.AllChartTypes[1];
		static MorrisBar: ChartType = ChartType.AllChartTypes[2];
		static MorrisDonut: ChartType = ChartType.AllChartTypes[3];

		//
		// Determines the chart type by looking at two specific
		// attributes on the div tag
		//
		static findChartType(htmlElement: JQuery): ChartType {
			var returnValue: ChartType = undefined

			//
			// Get the chart library and type from the attributes
			//
			var library = htmlElement.attr(ChartType.LibraryTag);
			var type = htmlElement.attr(ChartType.ChartTag);

			//
			// jQuery returns undefined if the attributes are not defined
			//
			if (library != undefined) {
				if (type != undefined) {
					//
					// Search the array for the library
					//
					for (var i = 0; i < ChartType.AllChartTypes.length; i++) {
						var item = ChartType.AllChartTypes[i];

						if (item.library == library && item.name == type) {
							//
							// Set the return item and break from the loop
							//
							returnValue = item;
							break;
						}
					};

					//
					// make sure a chart type was found
					//
					if (returnValue == undefined) {
						jQuery.error('The chart type "' + library + '.' + type + '" is not supported.');
					}
				}
				else {
					//
					// Throw an exception
					//
					jQuery.error('The chart is missing attribute "' + ChartType.ChartTag + '"');
				}
			}
			else {
				//
				// Throw an exception
				//
				jQuery.error('The chart is missing attribute "' + ChartType.LibraryTag + '"');
			}

			return returnValue;
		}
	}

	//
	// Represents a callback formatter for text in a chart
	//
	class Formatter {
		constructor(public name: string, public format: any) {
		}

		static AllFormatters = [
			new Formatter('date', function (value, formatString) { return moment(value).format(formatString); }),
			new Formatter('append', function (value, formatString) { return value + formatString; }),
			new Formatter('prepend', function (value, formatString) { return formatString + value; }),
			new Formatter('currency', function (value, formatString) { return formatString + value; })
		];

		//
		// Determines the formatter by name
		//
		static findFormatter(name: string): Formatter {
			var returnValue: Formatter = undefined;

			//
			// Search the array for the library
			//
			for (var i = 0; i < Formatter.AllFormatters.length; i++) {
				var item = Formatter.AllFormatters[i];

				if (item.name == name) {
					//
					// Set the return item and break from the loop
					//
					returnValue = item;
					break;
				}
			};

			//
			// Make sure a chart type was found
			//
			if (returnValue == undefined) {
				jQuery.error('The formatter "' + name + '" does not exist.');
			}

			return returnValue;
		}
	}

	//
	// Represents a type of chart option and defines how to convert
	// the string value in the attribute to the necessary data type
	// for the given option.
	//
	class OptionType {
		constructor(public name: string, public getValue: any) {
		}

		static String: OptionType = new OptionType('string', function (value: string): string { return value; });
		static Callback: OptionType = new OptionType('callback', undefined);
		static FormatCallback: OptionType = new OptionType('formatCallback', function (value: string): string { return this.setFormatCallbackOption(value); });
		static Boolean: OptionType = new OptionType('boolean', function (value: string): boolean { return (value == "true"); });
		static StringArray: OptionType = new OptionType('stringArray', function (value: string): string[] { return value.split(","); });
		static FloatArray: OptionType = new OptionType('floatArray', function (value: string): number[] { var returnValue: number[]; for (var a in value.split(",")) { returnValue.push(parseFloat(a)) }; return returnValue });

		setFormatCallbackOption(value: string): any {
			var returnValue: any

			//
			// Get the value that contains the formatter type and the format string
			// which is in the format 'formatterType[formatString]'
			//
			var expression = /\s*\((.+?)\)/;

			//
			// Parse the formatter
			//
			if (expression.test(value)) {
				//
				// Parse the string
				//
				var parsed = value.split(expression);

				//
				// The formatter type will choose the function
				// to call.
				//
				var formatterType = parsed[0];

				//
				// The formatString is passed to the function
				//
				var formatString = parsed[1];

				//
				// Find the formatter
				//
				var formatter = Formatter.findFormatter(formatterType);

				//
				// Choose the correct formatter by type
				//
				if (formatter == undefined) {
					//
					// There is no formatter function defined for this type
					//
					jQuery.error('The formatter type "' + formatterType + '" is not a recognized callback formatter.');
				}
				else {
					//
					// Assign the callback to the chart option. This is essentially
					// assigning a function within a function.
					//
					returnValue = function (value) { return formatter.format(value, formatString); };
				}
			}
			else {
				//
				// The entire attribute value was not recognized (could not be parsed)
				//
				jQuery.error('The formatter text "' + value + '" is not recognized.');
			}

			return returnValue;
		}
	}

	//
	// Defines an option for a chart specifying the chart types that support
	// the option.
	//
	class ChartOption {
		constructor(public name: string, public isRequired: Boolean,
			public autoLoad: Boolean, public chart: ChartType[], public optionType: OptionType) {
		}

		attributeName() {
			var returnValue: string = undefined;

			if (this.name == 'element') {
				returnValue = 'id';
			}
			else {
				returnValue = 'data-chart-' + this.name;
			}

			return returnValue;
		}

		static AllOptions: ChartOption[] = [
			new ChartOption('element', true, true, [ChartType.MorrisArea, ChartType.MorrisLine, ChartType.MorrisBar, ChartType.MorrisDonut], OptionType.String),
			new ChartOption('dataUrl', true, true, [ChartType.MorrisArea, ChartType.MorrisLine, ChartType.MorrisBar, ChartType.MorrisDonut], OptionType.String),
			new ChartOption('xkey', true, true, [ChartType.MorrisArea, ChartType.MorrisLine, ChartType.MorrisBar], OptionType.String),
			new ChartOption('ykeys', true, true, [ChartType.MorrisArea, ChartType.MorrisLine, ChartType.MorrisBar], OptionType.StringArray),
			new ChartOption('labels', true, true, [ChartType.MorrisArea, ChartType.MorrisLine, ChartType.MorrisBar], OptionType.StringArray),
			new ChartOption('lineColors', false, true, [ChartType.MorrisArea, ChartType.MorrisLine], OptionType.StringArray),
			new ChartOption('lineWidth', false, true, [ChartType.MorrisArea, ChartType.MorrisLine], OptionType.String),
			new ChartOption('pointSize', false, true, [ChartType.MorrisArea, ChartType.MorrisLine], OptionType.String),
			new ChartOption('pointFillColors', false, true, [ChartType.MorrisArea, ChartType.MorrisLine], OptionType.StringArray),
			new ChartOption('pointStrokeColors', false, true, [ChartType.MorrisArea, ChartType.MorrisLine], OptionType.StringArray),
			new ChartOption('ymax', false, true, [ChartType.MorrisArea, ChartType.MorrisLine], OptionType.String),
			new ChartOption('ymin', false, true, [ChartType.MorrisArea, ChartType.MorrisLine], OptionType.String),
			new ChartOption('smooth', false, true, [ChartType.MorrisArea, ChartType.MorrisLine], OptionType.Boolean),
			new ChartOption('hideHover', false, true, [ChartType.MorrisArea, ChartType.MorrisLine, ChartType.MorrisBar], OptionType.String),
			new ChartOption('hoverCallback', false, true, [ChartType.MorrisArea, ChartType.MorrisLine, ChartType.MorrisBar], OptionType.Callback),
			new ChartOption('parseTime', false, true, [ChartType.MorrisArea, ChartType.MorrisLine], OptionType.Boolean),
			new ChartOption('units', false, true, [ChartType.MorrisArea, ChartType.MorrisLine], OptionType.String),
			new ChartOption('postUnits', false, true, [ChartType.MorrisArea, ChartType.MorrisLine], OptionType.String),
			new ChartOption('preUnits', false, true, [ChartType.MorrisArea, ChartType.MorrisLine], OptionType.String),
			new ChartOption('dateFormat', false, true, [ChartType.MorrisArea, ChartType.MorrisLine], OptionType.FormatCallback),
			new ChartOption('xLabels', false, true, [ChartType.MorrisArea, ChartType.MorrisLine], OptionType.String),
			new ChartOption('xLabelFormat', false, true, [ChartType.MorrisArea, ChartType.MorrisLine], OptionType.FormatCallback),
			new ChartOption('yLabelFormat', false, true, [ChartType.MorrisArea, ChartType.MorrisLine], OptionType.FormatCallback),
			new ChartOption('goals', false, true, [ChartType.MorrisArea, ChartType.MorrisLine], OptionType.FloatArray),
			new ChartOption('goalStrokeWidth', false, true, [ChartType.MorrisArea, ChartType.MorrisLine], OptionType.String),
			new ChartOption('goalLineColors', false, true, [ChartType.MorrisArea, ChartType.MorrisLine], OptionType.StringArray),
			new ChartOption('events', false, true, [ChartType.MorrisArea, ChartType.MorrisLine], OptionType.StringArray),
			new ChartOption('eventStrokeWidth', false, true, [ChartType.MorrisArea, ChartType.MorrisLine], OptionType.String),
			new ChartOption('eventLineColors', false, true, [ChartType.MorrisArea, ChartType.MorrisLine], OptionType.StringArray),
			new ChartOption('continuousLine', false, true, [ChartType.MorrisArea, ChartType.MorrisLine], OptionType.String),
			new ChartOption('axes', false, true, [ChartType.MorrisArea, ChartType.MorrisLine, ChartType.MorrisBar], OptionType.Boolean),
			new ChartOption('grid', false, true, [ChartType.MorrisArea, ChartType.MorrisLine, ChartType.MorrisBar], OptionType.Boolean),
			new ChartOption('gridTextColor', false, true, [ChartType.MorrisArea, ChartType.MorrisLine, ChartType.MorrisBar], OptionType.String),
			new ChartOption('gridTextSize', false, true, [ChartType.MorrisArea, ChartType.MorrisLine, ChartType.MorrisBar], OptionType.String),
			new ChartOption('gridTextFamily', false, true, [ChartType.MorrisArea, ChartType.MorrisLine, ChartType.MorrisBar], OptionType.String),
			new ChartOption('gridTextWeight', false, true, [ChartType.MorrisArea, ChartType.MorrisLine, ChartType.MorrisBar], OptionType.String),
			new ChartOption('fillOpacity', false, true, [ChartType.MorrisArea, ChartType.MorrisLine], OptionType.String),
			new ChartOption('behaveLikeLine', false, true, [ChartType.MorrisArea], OptionType.String),
			new ChartOption('barColors', false, true, [ChartType.MorrisBar], OptionType.StringArray),
			new ChartOption('stacked', false, true, [ChartType.MorrisBar], OptionType.Boolean),
			new ChartOption('colors', false, true, [ChartType.MorrisDonut], OptionType.StringArray),
			new ChartOption('formatter', false, true, [ChartType.MorrisDonut], OptionType.FormatCallback),
			new ChartOption('labelColor', false, true, [ChartType.MorrisDonut], OptionType.String),
			new ChartOption('backgroundColor', false, true, [ChartType.MorrisDonut], OptionType.String),
			new ChartOption('resize', false, true, [ChartType.MorrisArea, ChartType.MorrisLine, ChartType.MorrisBar, ChartType.MorrisDonut], OptionType.Boolean),
			new ChartOption('xLabelAngle', false, true, [ChartType.MorrisArea, ChartType.MorrisLine], OptionType.String)
		];
	}
}
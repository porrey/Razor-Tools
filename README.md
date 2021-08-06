![GitHub](https://img.shields.io/github/license/porrey/Razor-Tools?style=for-the-badge)
[![Build Status](https://img.shields.io/travis/porrey/Razor-Tools/master?style=for-the-badge)](https://travis-ci.com/porrey/Razor-Tools)

# RazorTools
The Razor Tools library is designed to wrap JavaScript and JQuery objects into C# methods. Objects can be easily added to Razor views with basic C# code. All objects are created and initialized using unobtrusive JavaScript techniques and fluent API. This allows complex objects to be created within your views with simple C# statements.
### Dependencies

The current version of these libraries are built for **.NET Core** with dependencies on **netstandard2.1** and **Microsoft.AspNetCore.Mvc.ViewFeatures**.

### Concept
The basic concept of RazorTools is to provide fluent APIs to create JQuery and JavScript objects in Razor views. Syntax such as 

	@Create<FancyObject>().WithStyle(Style.Cool).UsingData("Home", "Data")

can be used to generate complex objects that interact with the controller to retrieve data while keeping the view code clean and straight forward. In some cases, objects can also be render using simple statements such as

	@Html.BeginObject(new FancyObject("fancyObject123")
	{
		DataUrl = this.Url.Action("Home", "Data")
	})

# Documentation

See the [Wiki pages](https://github.com/porrey/Razor-Tools/wiki) for more detailed information.

> There are currently two libraries: [Charts](https://github.com/porrey/Razor-Tools/wiki/RazorTools-Charts) and [Font Awesome](https://github.com/porrey/Razor-Tools/wiki/RazorTools-Font-Awesome).
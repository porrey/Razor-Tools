![GitHub](https://img.shields.io/github/license/porrey/Razor-Tools?style=for-the-badge)
[![Build Status](https://img.shields.io/travis/porrey/Razor-Tools/master?style=for-the-badge)](https://travis-ci.com/porrey/Razor-Tools)

# RazorTools
The Razor Tools library is designed to wrap JavaScript and JQuery objects into C# methods. Objects can be easily added to Razor views with basic C# code. All objects are created and initialized using unobtrusive JavaScript techniques and fluent API. This allows complex objects to be created within your views with simple C# statements.

### Dependencies

The current version of these libraries are built for **.NET Core** with dependencies on **netstandard2.1**, **netcoreapp3.1** and **Microsoft.AspNetCore.Mvc.ViewFeatures**.

### Concept
The basic concept of RazorTools is to provide fluent APIs to create JQuery and JavScript objects in Razor views. Syntax such as 

	@(Create<FancyObject>().WithStyle(Style.Cool).UsingData("Home", "Data"))
can be used to generate complex objects that interact with the controller to retrieve data while keeping the view code clean and straight forward. In some cases, objects can also be render using simple statements such as

	@Html.RenderObject(new FancyObject("fancyObject123")
	{
		DataUrl = this.Url.Action("Home", "Data")
	})

## Base Object
[![Nuget](https://img.shields.io/nuget/v/Mvc.RazorTools.Base?label=Mvc.RazorTools.Base%20-%20NuGet&style=for-the-badge)
![Nuget](https://img.shields.io/nuget/dt/Mvc.RazorTools.Base?label=Downloads&style=for-the-badge)](https://www.nuget.org/packages/Mvc.RazorTools.Base/)

![](https://github.com/porrey/Razor-Tools/raw/master/Images/Mvc.RazorTools.Base-64.png)

This library provides the base class for all RazorTools objects. It provides the basic code for building tags and embedding them in Razor views. All of the RazorTools packages will be based on this library. Generally, you will not add this library directly to your project.

## Charts
[![Nuget](https://img.shields.io/nuget/v/Mvc.RazorTools.Charts?label=Mvc.RazorTools.Charts%20-%20NuGet&style=for-the-badge)
![Nuget](https://img.shields.io/nuget/dt/Mvc.RazorTools.Charts?label=Downloads&style=for-the-badge)](https://www.nuget.org/packages/Mvc.RazorTools.Charts/)

![](https://github.com/porrey/Razor-Tools/raw/master/Images/Mvc.RazorTools.Charts-64.png)

### Overview
Create simple charts in your Razor views. This library wraps [morris.js](http://morrisjs.github.io/morris.js/) charts along with some other tools to produce nice looking charts.

### Install
To install use the .NET CLI

	>dotnet add package Mvc.RazorTools.Charts

or Package manager

	PM>Install-Package Mvc.RazorTools.Charts

### Documentation
For more information see the documentation in the repo Wiki pages: [RazorTools - Charts documentation](https://github.com/porrey/Razor-Tools/wiki/RazorTools-Charts).

## Font Awesome
[![Nuget](https://img.shields.io/nuget/v/Mvc.RazorTools.FontAwesome?label=Mvc.RazorTools.FontAwesome%20-%20NuGet&style=for-the-badge)
![Nuget](https://img.shields.io/nuget/dt/Mvc.RazorTools.FontAwesome?label=Downloads&style=for-the-badge)](https://www.nuget.org/packages/Mvc.RazorTools.FontAwesome/)

![](https://github.com/porrey/Razor-Tools/raw/master/Images/Mvc.RazorTools.FontAwesome-64.png)

### Overview
Use [Font Awesome](https://fontawesome.com/) icon in your views with a fluent API. referenc your Font Awesome package or download and install the files locally.

### Install
To install use the .NET CLI

	>dotnet add package Mvc.RazorTools.FontAwesome

or Package manager

	PM>Install-Package Mvc.RazorTools.FontAwesome

### Documentation
For more information see the documentation in the repo Wiki pages: [RazorTools - Font Awesome documentation](https://github.com/porrey/Razor-Tools/wiki/Font-Awesome).

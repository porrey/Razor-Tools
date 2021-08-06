//
// Razor Tools Unobtrusive DataTables for jQuery (https://datatables.codeplex.com)
// Copyright 2013-2020 Daniel M. Porrey
// Licensed under https://datatables.codeplex.com/license
//
$(function () {
	//
	// Find all tables tagged with "data-create-data-table"
	//
	$('table[data-create-data-table]').each(function () {
		//
		// Get a reference to the HTML element on
		// which the data table is to be created
		//
		var dataTable = $(this).dataTable();

		//
		// Enable the auto fill extension if the tag is specified
		//
		//if ($(this).attr("data-autofill-enable") != undefined) {
		//	new $.fn.dataTable.AutoFill(dataTable);
		//}

		//
		// Enable the key table extension if the tag is specified
		//
		//if ($(this).attr("data-keytable-enable") != undefined) {
		//	new $.fn.dataTable.KeyTable(dataTable);
		//}
	});
});
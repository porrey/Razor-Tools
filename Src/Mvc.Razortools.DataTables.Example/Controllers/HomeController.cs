//
// Copyright(C) 2014-2020, Daniel M. Porrey. All rights reserved.
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published
// by the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program. If not, see http://www.gnu.org/licenses/.
//
using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Mvc.RazorTools.DataTables;
using Mvc.RazorTools.DataTables.Example;

namespace Mvc.Razortools.DataTables.Example.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return this.View();
		}

		[HttpPost]
		public ActionResult TableData(DataTableRequest model)
		{
			DataTableResult<EmployeeRow> returnValue = new DataTableResult<EmployeeRow>();

			if (model.Search != null && !String.IsNullOrEmpty(model.Search.Value))
			{
				Debug.WriteLine(String.Format("Searching for '{0}' at {1}.", model.Search.Value, DateTime.Now.ToLongTimeString()));
			}

			using (EmployeeContext db = new EmployeeContext())
			{
				returnValue.Data = (from tbl in db.Employees
									select new EmployeeRow()
									{
										RowId = tbl.Id.ToString(),
										RowAttributes = new { dataItem = $"{tbl.Id}", dataValue = $"{tbl.LastName}" },
										RowClass = "myclass",
										RowData = tbl,
										Id = tbl.Id,
										FirstName = tbl.FirstName,
										LastName = tbl.LastName,
										CompanyName = tbl.CompanyName,
										Address = tbl.Address,
										City = tbl.City,
										County = tbl.County,
										State = tbl.State,
										Zip = tbl.State,
										Email = tbl.Email,
										MobilePhoneNumber = tbl.MobilePhoneNumber,
										WorkPhoneNumber = tbl.WorkPhoneNumber,
										WebSite = tbl.WebSite
									}).Skip(model.Start).Take(model.Length).ToArray();

				returnValue.Draw = model.Draw;
				returnValue.RecordsFiltered = db.Employees.Count();
				returnValue.RecordsTotal = db.Employees.Count();
			}

			return this.Json(returnValue);
		}
	}
}

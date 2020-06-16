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

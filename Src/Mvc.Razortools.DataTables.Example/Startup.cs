using System.Collections;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Mvc.RazorTools.DataTables.Example;
using Newtonsoft.Json;

namespace Mvc.Razortools.DataTables.Example
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			this.Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllersWithViews();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
			});

			using (EmployeeContext db = new EmployeeContext())
			{
				string json = File.ReadAllText(@"Data\Employees.json");
				IEnumerable<Employee> items = JsonConvert.DeserializeObject<IEnumerable<Employee>>(json);
				db.Employees.AddRange(items);
				db.SaveChanges();
			}
		}
	}
}

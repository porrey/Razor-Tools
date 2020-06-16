using Microsoft.EntityFrameworkCore;

namespace Mvc.RazorTools.DataTables.Example
{
	public class EmployeeContext : DbContext
	{
		public EmployeeContext()
			: base()
		{
		}

		public virtual DbSet<Employee> Employees { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseInMemoryDatabase("Employees");
		}
	}
}
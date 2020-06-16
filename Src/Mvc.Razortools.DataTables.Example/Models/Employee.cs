using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mvc.RazorTools.DataTables.Example
{
	[Table("Employees")]
	public class Employee : IEmployee
	{
		[Column("EmployeeId")]
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[StringLength(50)]
		public string FirstName { get; set; }

		[StringLength(50)]
		public string LastName { get; set; }

		[StringLength(50)]
		public string CompanyName { get; set; }

		[StringLength(50)]
		public string Address { get; set; }

		[StringLength(35)]
		public string City { get; set; }

		[StringLength(35)]
		public string County { get; set; }

		[StringLength(2)]
		public string State { get; set; }

		[StringLength(5)]
		public string Zip { get; set; }

		[StringLength(12)]
		public string WorkPhoneNumber { get; set; }

		[StringLength(12)]
		public string MobilePhoneNumber { get; set; }

		[StringLength(256)]
		public string Email { get; set; }

		[StringLength(256)]
		public string WebSite { get; set; }
	}
}

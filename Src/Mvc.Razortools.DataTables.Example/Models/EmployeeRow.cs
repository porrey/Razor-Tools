using Newtonsoft.Json;

namespace Mvc.RazorTools.DataTables.Example
{
	public class EmployeeRow : DataTableItem<Employee>, IEmployee
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("firstName")]
		public string FirstName { get; set; }

		[JsonProperty("lastName")]
		public string LastName { get; set; }

		[JsonProperty("companyName")]
		public string CompanyName { get; set; }

		[JsonProperty("address")]
		public string Address { get; set; }

		[JsonProperty("city")]
		public string City { get; set; }

		[JsonProperty("county")]
		public string County { get; set; }

		[JsonProperty("state")]
		public string State { get; set; }

		[JsonProperty("zip")]
		public string Zip { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("mobilePhoneNumber")]
		public string MobilePhoneNumber { get; set; }

		[JsonProperty("workPhoneNumber")]
		public string WorkPhoneNumber { get; set; }

		[JsonProperty("webSite")]
		public string WebSite { get; set; }
	}
}

namespace Mvc.RazorTools.DataTables.Example
{
	public interface IEmployee
	{
		int Id { get; set; }
		string FirstName { get; set; }
		string LastName { get; set; }
		string CompanyName { get; set; }
		string Address { get; set; }
		string City { get; set; }
		string County { get; set; }
		string State { get; set; }
		string Zip { get; set; }
		string Email { get; set; }
		string MobilePhoneNumber { get; set; }
		string WorkPhoneNumber { get; set; }
		string WebSite { get; set; }
	}
}
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

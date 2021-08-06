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

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
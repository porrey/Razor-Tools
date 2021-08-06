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
using Newtonsoft.Json;

namespace Mvc.RazorTools.DataTables
{
	public class Column
	{
		[JsonProperty("title")]
		public string Title { get; set; } = String.Empty;

		[JsonProperty("data")]
		public string Data { get; set; } = String.Empty;

		[JsonProperty("name")]
		public string Name { get; set; } = String.Empty;

		[JsonProperty("searchable")]
		public bool Searchable { get; set; } = true;

		[JsonProperty("orderable")]
		public bool Orderable { get; set; } = true;

		[JsonProperty("search")]
		public Search Search { get; set; } = null;

		[JsonProperty("type")]
		public string Type { get; set; } = "string";

		[JsonProperty("filterable")]
		public bool Filterable { get; set; } = true;
	}
}

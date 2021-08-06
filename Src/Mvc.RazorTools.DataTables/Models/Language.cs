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

namespace Mvc.RazorTools.DataTables
{
	/// <summary>
	/// All strings that DataTables uses in its user interface are defined in this object,
	/// allowing you to modified them individually or completely replace them all as required.
	/// This ensures that DataTables is fully internationalizable as strings for any language
	/// can be used.
	/// </summary>
	public class Language
	{
		/// <summary>
		/// When using Ajax sourced data and during the first draw when DataTables is gathering
		/// the data, this message is shown in an empty row in the table to indicate to the end
		/// user the data is being loaded. Note that this parameter is not used when loading
		/// data by server-side processing, just Ajax sourced data with client-side processing.
		/// </summary>
		[JsonProperty("loadingRecords")]
		public string LoadingRecords { get; set; }

		/// <summary>
		/// Text that is displayed when the table is processing a user action (usually a
		/// sort command or similar).
		/// </summary>
		[JsonProperty("processing")]
		public string Processing { get; set; }
	}
}

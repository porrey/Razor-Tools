// ***
// *** Copyright(C) 2019-2020, Daniel M. Porrey. All rights reserved.
// *** 
// *** This program is free software: you can redistribute it and/or modify
// *** it under the terms of the GNU Lesser General Public License as published
// *** by the Free Software Foundation, either version 3 of the License, or
// *** (at your option) any later version.
// *** 
// *** This program is distributed in the hope that it will be useful,
// *** but WITHOUT ANY WARRANTY; without even the implied warranty of
// *** MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// *** GNU Lesser General Public License for more details.
// *** 
// *** You should have received a copy of the GNU Lesser General Public License
// *** along with this program. If not, see http://www.gnu.org/licenses/.
// ***
namespace Mvc.RazorTools.Charts
{
	/// <summary>
	/// This formatter uses moment.js to format dates and times. use
	/// the moment.js syntax in the FormatString.
	/// </summary>
	public class DateFormatter : CallbackFormatter
	{
		/// <summary>
		/// Creates an instance of a <see cref="DateFormatter"/>
		/// with the specified format string.
		/// </summary>
		/// <param name="formatString">A format string representing how the date/time should be displayed. This formatter
		/// uses Moment.js for formatting date time values.</param>
		public DateFormatter(string formatString)
			: base("Date")
		{
			this.FormatString = formatString;
		}
	}
}

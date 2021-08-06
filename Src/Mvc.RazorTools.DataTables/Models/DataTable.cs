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
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Html;
using Newtonsoft.Json;

namespace Mvc.RazorTools.DataTables
{
	public class RazorDataTable : RazorToolsObject
	{
		public RazorDataTable()
			: base()
		{
			this.HtmlTag = "table";
			this.IncludeIdInHtml = true;
		}

		public RazorDataTable(string id)
			: base(id)
		{
			this.HtmlTag = "table";
			this.IncludeIdInHtml = true;
		}

		protected override IHtmlContent OnGetHtml()
		{
			IHtmlContentBuilder builder = new HtmlContentBuilder();

			builder.AppendHtml($"<{this.HtmlTag}");

			if (this.IncludeIdInHtml)
			{
				builder.AppendHtml($" id='{this.Id}'");
			}

			builder.AppendHtml(" data-create-data-table");

			if (this.ClassAttributes.Count() > 0)
			{
				builder.AppendHtml($" class=\"{String.Join(" ", this.ClassAttributes)}\"");
			}

			foreach (KeyValuePair<string, string> attr in this.Attributes)
			{
				builder.AppendHtml($" {attr.Key}=\"{attr.Value}\"");
			}

			foreach (KeyValuePair<string, object> dataAttr in this.DataAttributes)
			{
				Type t = dataAttr.Value.GetType();

				if (t == typeof(string))
				{
					builder.AppendHtml($" data-{dataAttr.Key}='{dataAttr.Value}'");
				}
				else
				{
					string json = JsonConvert.SerializeObject(dataAttr.Value);
					builder.AppendHtml($" data-{dataAttr.Key}='{json}'");
				}
			}

			builder.AppendHtml(">");
			builder.AppendHtml($"</{this.HtmlTag}>");

			return builder;
		}
	}
}

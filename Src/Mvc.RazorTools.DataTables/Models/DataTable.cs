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

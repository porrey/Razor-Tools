using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace Mvc.RazorTools.DataTables
{
	public static class HtmlExtensions
	{
		public static IHtmlContent AjaxOption(this IHtmlHelper html, string url, string type = MethodTypes.Post)
		{
			Ajax option = new Ajax()
			{
				Url = url,
				Type = type
			};

			return html.Raw(JsonConvert.SerializeObject(option));
		}

		public static IHtmlContent ColumnsOption(this IHtmlHelper html, IEnumerable<Column> option)
		{
			return html.Raw(JsonConvert.SerializeObject(option));
		}

		public static IHtmlContent LanguageOption(this IHtmlHelper html, Language option)
		{
			return html.Raw(JsonConvert.SerializeObject(option));
		}
	}
}

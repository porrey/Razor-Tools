using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mvc.RazorTools.DataTables
{
	public static class DataTables
	{
		public static RazorDataTable Create(string id)
		{
			return new RazorDataTable(id);
		}

		public static RazorDataTable UsingDataFrom(this RazorDataTable table, string url, string type = MethodTypes.Post)
		{
			Ajax option = new Ajax()
			{
				Url = url,
				Type = type
			};

			table.AddDataAttribute("ajax", JsonConvert.SerializeObject(option));
			return table;
		}

		public static RazorDataTable WithAttribute(this RazorDataTable table, string name, string value)
		{
			table.AddAttribute(name, value);
			return table;
		}

		public static RazorDataTable WithDataAttribute(this RazorDataTable table, string name, object value)
		{
			table.AddDataAttribute(name, value);
			return table;
		}

		public static RazorDataTable WithClass(this RazorDataTable table, params string[] values)
		{
			table.MergeClassAttributes(values);
			return table;
		}

		public static RazorDataTable WithLanguageOption(this RazorDataTable table, Language option)
		{
			table.AddDataAttribute("language", JsonConvert.SerializeObject(option));
			return table;
		}

		public static RazorDataTable WithColumns(this RazorDataTable table, IEnumerable<Column> colums)
		{
			table.AddDataAttribute("columns", JsonConvert.SerializeObject(colums));
			return table;
		}
	}
}

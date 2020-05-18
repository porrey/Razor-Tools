using System;

namespace Mvc.RazorTools.Charts
{
	/// <summary>
	/// A formatter used for JavaScript callbacks.
	/// </summary>
	public abstract class CallbackFormatter : IFormatCallback
	{
		/// <summary>
		/// Creates an instance of <see cref="CallbackFormatter"/> with
		/// the specified type.
		/// </summary>
		/// <param name="type"></param>
		protected CallbackFormatter(string type)
		{
			this.Type = type;
		}

		/// <summary>
		/// Gets the Type name that this formatter represents.
		/// </summary>
		public string Type { get; protected set; }

		/// <summary>
		/// Gets/sets the format string for this formatter.
		/// </summary>
		public string FormatString { get; set; }

		/// <summary>
		/// Gets the attribute value written tot he TML tag for this formatter.
		/// </summary>
		public string AttributeValue
		{
			get
			{
				return String.Format("{0}({1})", this.Type.ToLower(), this.FormatString);
			}
		}
	}
}

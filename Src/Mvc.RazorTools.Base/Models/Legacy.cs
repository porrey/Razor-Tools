using System;

namespace Mvc.RazorTools
{
	/// <summary>
	/// 
	/// </summary>
	[Obsolete("Derive objects from RazorToolsObject")]
	public class MvcRazorObject : RazorToolsObject
	{
		/// <summary>
		/// 
		/// </summary>
		protected MvcRazorObject()
			: base()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		protected MvcRazorObject(string id)
			: base(id)
		{
		}
	}

	/// <summary>
	/// Legacy interface.
	/// </summary>
	[Obsolete("Use IMvcRazorAttributes.")]
	public interface IMvcRazorAttributes : IRazorToolsAttributes
	{
	}

	/// <summary>
	/// Legacy interface.
	/// </summary>
	[Obsolete("Use IMvcRazorStyles.")]
	public interface IMvcRazorStyles : IRazorToolsStyles
	{
	}

	/// <summary>
	/// Legacy interface.
	/// </summary>
	[Obsolete("Use IMvcRazorObject.")]
	public interface IMvcRazorObject : IRazorToolsObject
	{
	}

	/// <summary>
	/// Legacy interface.
	/// </summary>
	[Obsolete("Use IMvcRazorClassAttributes.")]
	public interface IMvcRazorClassAttributes : IRazorToolsClassAttributes
	{
	}
}

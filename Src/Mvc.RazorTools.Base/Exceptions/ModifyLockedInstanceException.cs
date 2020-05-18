namespace Mvc.RazorTools
{
	/// <summary>
	/// Defines an exception thrown when trying to modify a locked icon instance.
	/// </summary>
	public class ModifyLockedInstanceException : MvcRazorException
	{
		/// <summary>
		/// Initializes a new instance of this exception.
		/// </summary>
		public ModifyLockedInstanceException()
			: base("The properties for this locked instance cannot be modified.")
		{
		}
	}
}

using System;
using System.Runtime.Serialization;

namespace Mvc.RazorTools
{
	/// <summary>
	/// Provides a abstract definition for an exception in this library.
	/// </summary>
	public abstract class MvcRazorException : Exception
	{
		/// <summary>
		/// Initializes a new instance of the Mvc.RazorTools.MvcRazorException class.
		/// </summary>
		public MvcRazorException()
			: base()
		{
		}

		/// <summary>
		/// Initializes a new instance of the Mvc.RazorTools.MvcRazorException 
		/// class with the specified error message.
		/// </summary>
		/// <param name="message">A System.String containing the error message that describes the exception.</param>
		public MvcRazorException(string message)
			: base(message)
		{
		}

		/// <summary>
		/// Initializes a new instance of the Mvc.RazorTools.MvcRazorException 
		/// class with the specified formatted error message.
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="args">An object array that contains zero or more objects to format.</param>
		public MvcRazorException(string format, params object[] args)
			: base(string.Format(format, args))
		{
		}

		/// <summary>
		/// Initializes a new instance of the Mvc.RazorTools.MvcRazorException
		/// class with a specified error message and a reference to the inner exception 
		/// that is the cause of this exception.
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException">The exception that is the cause of the current exception, or a null reference
		/// (Nothing in Visual Basic) if no inner exception is specified.</param>
		public MvcRazorException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		/// <summary>
		/// When overridden in a derived class, sets the System.Runtime.Serialization.SerializationInfo 
		/// with information about the exception.
		/// </summary>
		/// <param name="info">The System.Runtime.Serialization.SerializationInfo that holds the serialized 
		/// object data about the exception being thrown.</param>
		/// <param name="context">The System.Runtime.Serialization.StreamingContext that contains contextual 
		/// information about the source or destination.</param>
		public MvcRazorException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}

using System;
using System.Runtime.Serialization;

namespace Mvc.RazorTools.FontAwesome
{
	/// <summary>
	/// Provides a abstract definition for an exception in this library.
	/// </summary>
	public abstract class FontAwesomeException : RazorToolsException
	{
		/// <summary>
		/// Initializes a new instance of the Mvc.RazorTools.FontAwesome.FontAwesomeException class.
		/// </summary>
		public FontAwesomeException()
			: base()
		{
		}

		/// <summary>
		/// Initializes a new instance of the Mvc.RazorTools.FontAwesome.FontAwesomeException 
		/// class with the specified error message.
		/// </summary>
		/// <param name="message">A System.String containing the error message that describes the exception.</param>
		public FontAwesomeException(string message)
			: base(message)
		{
		}

		/// <summary>
		/// Initializes a new instance of the Mvc.RazorTools.FontAwesome.FontAwesomeException 
		/// class with the specified formatted error message.
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="args">An object array that contains zero or more objects to format.</param>
		public FontAwesomeException(string format, params object[] args)
			: base(String.Format(format, args))
		{
		}

		/// <summary>
		/// Initializes a new instance of the Mvc.RazorTools.FontAwesome.FontAwesomeException
		/// class with a specified error message and a reference to the inner exception 
		/// that is the cause of this exception.
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException">The exception that is the cause of the current exception, or a null reference
		/// (Nothing in Visual Basic) if no inner exception is specified.</param>
		public FontAwesomeException(string message, Exception innerException)
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
		public FontAwesomeException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}

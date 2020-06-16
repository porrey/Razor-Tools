// ***
// *** Copyright(C) 2014-2020, Daniel M. Porrey. All rights reserved.
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
using System;
using System.Runtime.Serialization;

namespace Mvc.RazorTools
{
	/// <summary>
	/// Provides a abstract definition for an exception in this library.
	/// </summary>
	public abstract class RazorToolsException : Exception
	{
		/// <summary>
		/// Initializes a new instance of the Mvc.RazorTools.MvcRazorException class.
		/// </summary>
		public RazorToolsException()
			: base()
		{
		}

		/// <summary>
		/// Initializes a new instance of the Mvc.RazorTools.MvcRazorException 
		/// class with the specified error message.
		/// </summary>
		/// <param name="message">A <see cref="String"/> containing the error message that describes the exception.</param>
		public RazorToolsException(string message)
			: base(message)
		{
		}

		/// <summary>
		/// Initializes a new instance of the Mvc.RazorTools.MvcRazorException 
		/// class with the specified formatted error message.
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="args">An object array that contains zero or more objects to format.</param>
		public RazorToolsException(string format, params object[] args)
			: base(String.Format(format, args))
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
		public RazorToolsException(string message, Exception innerException)
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
		public RazorToolsException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}

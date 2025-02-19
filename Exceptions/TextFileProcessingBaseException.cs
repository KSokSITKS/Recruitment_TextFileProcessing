using System;
using System.Runtime.Serialization;

namespace TextFileProcessing.Exceptions
{

	public class TextFileProcessingBaseException : Exception
	{
		public TextFileProcessingBaseException()
		{
		}

		public TextFileProcessingBaseException(string message) : base(message)
		{
		}

		public TextFileProcessingBaseException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected TextFileProcessingBaseException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}

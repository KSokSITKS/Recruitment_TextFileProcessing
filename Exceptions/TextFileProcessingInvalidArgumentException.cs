using System;
using System.Runtime.Serialization;

namespace TextFileProcessing.Exceptions
{

	public class TextFileProcessingInvalidArgumentException : TextFileProcessingBaseException
	{
		public TextFileProcessingInvalidArgumentException()
		{
		}

		public TextFileProcessingInvalidArgumentException(string message) : base(message)
		{
		}

		public TextFileProcessingInvalidArgumentException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected TextFileProcessingInvalidArgumentException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}

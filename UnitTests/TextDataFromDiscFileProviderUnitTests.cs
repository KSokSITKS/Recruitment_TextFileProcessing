using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextFileProcessing.Exceptions;
using TextFileProcessing.TextDataLoader;

namespace UnitTests
{
	[TestClass]
	public class TextDataFromDiscFileProviderUnitTests
	{
		[TestMethod]
		[ExpectedException(typeof(TextFileProcessingInvalidArgumentException))]
		public void Should_ThrowException_When_FilePathIsEmpty()
		{
			var provider = new TextDataFromDiscFileProvider(string.Empty);
			provider.GetTextData();
		}

		[TestMethod]
		[ExpectedException(typeof(TextFileProcessingInvalidArgumentException))]
		public void Should_ThrowException_When_FilePathIsNull()
		{
			var provider = new TextDataFromDiscFileProvider(null);
			provider.GetTextData();
		}

		[TestMethod]
		[ExpectedException(typeof(TextFileProcessingInvalidArgumentException))]
		public void Should_ThrowException_When_FileDoesNotExist()
		{
			var provider = new TextDataFromDiscFileProvider("someInvalidFilePath.txt");
			provider.GetTextData();
		}

		[TestMethod]
		public void Should_ReturnFileContent_When_FilePathIsValid()
		{
			var validFilePath = "validFilePath.txt";
			File.WriteAllText(validFilePath, "This is a test file.");

			try
			{
				var provider = new TextDataFromDiscFileProvider(validFilePath);
				var content = provider.GetTextData();
				Assert.AreEqual("This is a test file.", content);
			}
			finally
			{
				if (File.Exists(validFilePath))
				{
					File.Delete(validFilePath);
				}
			}
		}
	}
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextFileProcessing.TextDataProcessing.Strategies;

namespace UnitTests
{
	[TestClass]
	public class TextDataWordsCounterStrategyUnitTests
	{
		[TestMethod]
		public void Should_ReturnZero_When_DataIsEmptyString()
		{
			var strategy = new TextDataWordsCounterStrategy();
			var result = strategy.ProcessData(string.Empty);

			Assert.AreEqual("0", result);
		}

		[TestMethod]
		public void Should_ReturnZero_When_DataIsNull()
		{
			var strategy = new TextDataWordsCounterStrategy();
			var result = strategy.ProcessData(null);

			Assert.AreEqual("0", result);
		}

		[TestMethod]
		public void Should_ReturnWordCount_When_DataIsNonEmptyString()
		{
			var strategy = new TextDataWordsCounterStrategy();
			var result = strategy.ProcessData("This is a test.");

			Assert.AreEqual("4", result);
		}

		[TestMethod]
		public void Should_ReturnWordCount_When_DataContainsMultipleDelimiters()
		{
			var strategy = new TextDataWordsCounterStrategy();
			var result = strategy.ProcessData("This\tis\na\ttest.");

			Assert.AreEqual("4", result);
		}

		[TestMethod]
		public void Should_ReturnWordCount_When_DataContainsExtraSpaces()
		{
			var strategy = new TextDataWordsCounterStrategy();
			var result = strategy.ProcessData("  This  is  a  test.  ");

			Assert.AreEqual("4", result);
		}
	}
}


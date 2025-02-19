using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextFileProcessing.TextDataProcessing.Strategies;

namespace UnitTests
{
	[TestClass]
	public class TextDataSentencesCounterStrategyUnitTests
	{
		[TestMethod]
		public void Should_ReturnZero_When_DataIsEmptyString()
		{
			var strategy = new TextDataSentencesCounterStrategy();
			var result = strategy.ProcessData(string.Empty);

			Assert.AreEqual("0", result);
		}

		[TestMethod]
		public void Should_ReturnZero_When_DataIsNull()
		{
			var strategy = new TextDataSentencesCounterStrategy();
			var result = strategy.ProcessData(null);

			Assert.AreEqual("0", result);
		}

		[TestMethod]
		public void Should_ReturnSentenceCount_When_DataContainsPeriods()
		{
			var strategy = new TextDataSentencesCounterStrategy();
			var result = strategy.ProcessData("Sentence1.");

			Assert.AreEqual("1", result);
		}

		[TestMethod]
		public void Should_ReturnSentenceCount_When_DataContainsExclamationMarks()
		{
			var strategy = new TextDataSentencesCounterStrategy();
			var result = strategy.ProcessData("Sentence1!");

			Assert.AreEqual("1", result);
		}

		[TestMethod]
		public void Should_ReturnSentenceCount_When_DataContainsQuestionMarks()
		{
			var strategy = new TextDataSentencesCounterStrategy();
			var result = strategy.ProcessData("Sentence1?");

			Assert.AreEqual("1", result);
		}

		[TestMethod]
		public void Should_ReturnCorrectCount_When_DataContainsMultipleSentenceDelimiters()
		{
			var strategy = new TextDataSentencesCounterStrategy();
			var result = strategy.ProcessData("Sentence1! Sentence2? Sentence3. Sentence4.");

			Assert.AreEqual("4", result);
		}
	}
}

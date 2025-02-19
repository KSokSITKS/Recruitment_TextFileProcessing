using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextFileProcessing.TextDataProcessing.Strategies;

namespace UnitTests
{
	[TestClass]
	public class TextDataCharactersCounterStrategyUnitTests
	{
		[TestMethod]
		public void Should_ReturnZero_When_DataIsEmptyString()
		{
			var strategy = new TextDataCharactersCounterStrategy();
			var result = strategy.ProcessData(string.Empty);

			Assert.AreEqual("0", result);
		}

		[TestMethod]
		public void Should_ReturnZero_When_DataIsNull()
		{
			var strategy = new TextDataCharactersCounterStrategy();
			var result = strategy.ProcessData(null);

			Assert.AreEqual("0", result);
		}

		[TestMethod]
		public void Should_ReturnCharacterCount_When_DataIsNonEmptyString()
		{
			var strategy = new TextDataCharactersCounterStrategy();
			var result = strategy.ProcessData("This is a test.");

			Assert.AreEqual("15", result);
		}
	}
}

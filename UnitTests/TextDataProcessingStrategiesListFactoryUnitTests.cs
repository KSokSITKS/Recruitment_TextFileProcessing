using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextFileProcessing.Exceptions;
using TextFileProcessing.TextDataProcessing;
using TextFileProcessing.TextDataProcessing.Strategies;

namespace UnitTests
{
	[TestClass]
	public class TextDataProcessingStrategiesListFactoryUnitTests
	{
		[TestMethod]
		public void Should_ReturnEmptyList_When_StrategyTypesIsEmpty()
		{
			var factory = new TextDataProcessingStrategiesListFactory();
			var strategyTypes = new List<TextDataProcessingStrategyType>();
			var strategies = factory.Create(strategyTypes).ToList();

			Assert.AreEqual(0, strategies.Count);
		}

		[TestMethod]
		public void Should_ReturnCharactersCounterStrategy_When_StrategyTypeIsCharactersCounter()
		{
			var factory = new TextDataProcessingStrategiesListFactory();
			var strategyTypes = new List<TextDataProcessingStrategyType> { TextDataProcessingStrategyType.CharactersCounter };
			var strategies = factory.Create(strategyTypes).ToList();

			Assert.AreEqual(1, strategies.Count);
			Assert.IsInstanceOfType(strategies[0], typeof(TextDataCharactersCounterStrategy));
		}

		[TestMethod]
		public void Should_ReturnSentencesCounterStrategy_When_StrategyTypeIsSentencesCounter()
		{
			var factory = new TextDataProcessingStrategiesListFactory();
			var strategyTypes = new List<TextDataProcessingStrategyType> { TextDataProcessingStrategyType.SentencesCounter };
			var strategies = factory.Create(strategyTypes).ToList();

			Assert.AreEqual(1, strategies.Count);
			Assert.IsInstanceOfType(strategies[0], typeof(TextDataSentencesCounterStrategy));
		}

		[TestMethod]
		public void Should_ReturnWordsCounterStrategy_When_StrategyTypeIsWordsCounter()
		{
			var factory = new TextDataProcessingStrategiesListFactory();
			var strategyTypes = new List<TextDataProcessingStrategyType> { TextDataProcessingStrategyType.WordsCounter };
			var strategies = factory.Create(strategyTypes).ToList();

			Assert.AreEqual(1, strategies.Count);
			Assert.IsInstanceOfType(strategies[0], typeof(TextDataWordsCounterStrategy));
		}

		[TestMethod]
		[ExpectedException(typeof(TextFileProcessingInvalidArgumentException))]
		public void Should_ThrowException_When_StrategyTypeIsUnsupported()
		{
			var factory = new TextDataProcessingStrategiesListFactory();
			var strategyTypes = new List<TextDataProcessingStrategyType> { (TextDataProcessingStrategyType)999 };

			factory.Create(strategyTypes);
		}

		[TestMethod]
		public void Should_ReturnMultipleStrategies_When_MultipleStrategyTypesAreProvided()
		{
			var factory = new TextDataProcessingStrategiesListFactory();
			var strategyTypes = new List<TextDataProcessingStrategyType>
			{
				TextDataProcessingStrategyType.CharactersCounter,
				TextDataProcessingStrategyType.SentencesCounter,
				TextDataProcessingStrategyType.WordsCounter
			};
			var strategies = factory.Create(strategyTypes).ToList();

			Assert.AreEqual(3, strategies.Count);
		}
	}
}


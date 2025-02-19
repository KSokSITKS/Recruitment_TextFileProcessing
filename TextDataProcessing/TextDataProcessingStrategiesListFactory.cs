using System.Collections.Generic;
using TextFileProcessing.Exceptions;
using TextFileProcessing.TextDataProcessing.Interfaces;
using TextFileProcessing.TextDataProcessing.Strategies;

namespace TextFileProcessing.TextDataProcessing
{
    public class TextDataProcessingStrategiesListFactory : ITextDataProcessingStrategiesListFactory
	{
		public IEnumerable<ITextDataProcessingStrategy> Create(IEnumerable<TextDataProcessingStrategyType> strategyTypes)
		{
			var strategies = new List<ITextDataProcessingStrategy>();

			foreach (var strategyType in strategyTypes)
			{
				switch (strategyType)
				{
					case TextDataProcessingStrategyType.CharactersCounter:
						strategies.Add(new TextDataCharactersCounterStrategy());
						break;
					case TextDataProcessingStrategyType.SentencesCounter:
						strategies.Add(new TextDataSentencesCounterStrategy());
						break;
					case TextDataProcessingStrategyType.WordsCounter:
						strategies.Add(new TextDataWordsCounterStrategy());
						break;
					default:
						throw new TextFileProcessingInvalidArgumentException($"Nieobsługiwana strategia przetwarzania pliku {strategyType}");
				}
			}

			return strategies;
		}

	}
}

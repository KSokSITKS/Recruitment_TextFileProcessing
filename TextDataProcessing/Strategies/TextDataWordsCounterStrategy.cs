using System;
using TextFileProcessing.TextDataProcessing.Interfaces;

namespace TextFileProcessing.TextDataProcessing.Strategies
{
	public class TextDataWordsCounterStrategy : ITextDataProcessingStrategy
	{
		public string ProcessingResultDescription => "Liczba słów";

		public string ProcessData(string data)
		{
			var wordCount = 0;

			if (!string.IsNullOrWhiteSpace(data))
			{
				wordCount = data.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
			}

			return wordCount.ToString();
		}
	}
}

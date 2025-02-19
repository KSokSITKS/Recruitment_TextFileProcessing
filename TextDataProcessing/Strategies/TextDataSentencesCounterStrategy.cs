using System;
using TextFileProcessing.TextDataProcessing.Interfaces;

namespace TextFileProcessing.TextDataProcessing.Strategies
{
    public class TextDataSentencesCounterStrategy : ITextDataProcessingStrategy
    {
		public string ProcessingResultDescription => "Liczba zdań";
		public string ProcessData(string data)
		{
			var sentenceCount = 0;

			if (!string.IsNullOrWhiteSpace(data))
			{
				sentenceCount = data.Split(new[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).Length;
			}

			return sentenceCount.ToString();
		}
	}
}

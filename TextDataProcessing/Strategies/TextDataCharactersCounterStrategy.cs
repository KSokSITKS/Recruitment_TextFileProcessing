using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessing.TextDataProcessing.Interfaces;

namespace TextFileProcessing.TextDataProcessing.Strategies
{
    public class TextDataCharactersCounterStrategy : ITextDataProcessingStrategy
	{
		public string ProcessingResultDescription => "Liczba znaków";
		public string ProcessData(string data)
		{
			var charactersCount = 0;

			if (!string.IsNullOrWhiteSpace(data))
			{
				charactersCount = data.Length;
			}

			return charactersCount.ToString();
		}
	}
}

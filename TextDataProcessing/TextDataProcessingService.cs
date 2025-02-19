using System.Collections.Generic;
using System.Threading.Tasks;
using TextFileProcessing.TextDataLoader;
using TextFileProcessing.TextDataProcessing.Interfaces;

namespace TextFileProcessing.TextDataProcessing
{
	public class TextDataProcessingService : ITextDataProcessingService
	{
		public async Task<List<ProcessingResult>> ProcessData(ITextDataProvider dataProvider, IEnumerable<ITextDataProcessingStrategy> processingStrategies)
		{
			var data = dataProvider.GetTextData();
			var processingResults = new List<ProcessingResult>();

			foreach (var strategy in processingStrategies)
			{
				var processingResultDescprition = strategy.ProcessingResultDescription;
				var result = await Task.Run(() => strategy.ProcessData(data));
				var processingResult = new ProcessingResult(processingResultDescprition, result);

				processingResults.Add(processingResult);
			}

			return processingResults;
		}
	}
}

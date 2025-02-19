using System.Collections.Generic;
using System.Threading.Tasks;
using TextFileProcessing.TextDataLoader;

namespace TextFileProcessing.TextDataProcessing.Interfaces
{
    public interface ITextDataProcessingService
    {
        Task<List<ProcessingResult>> ProcessData(ITextDataProvider dataProvider, IEnumerable<ITextDataProcessingStrategy> processingStrategies);
	}
}

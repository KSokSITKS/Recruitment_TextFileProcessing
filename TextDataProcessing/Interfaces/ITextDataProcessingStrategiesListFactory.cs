using System.Collections.Generic;
using System.Linq.Expressions;

namespace TextFileProcessing.TextDataProcessing.Interfaces
{
    public interface ITextDataProcessingStrategiesListFactory
    {
		IEnumerable<ITextDataProcessingStrategy> Create(IEnumerable<TextDataProcessingStrategyType> strategyTypes);
	}
}

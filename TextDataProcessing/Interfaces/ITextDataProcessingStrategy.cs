namespace TextFileProcessing.TextDataProcessing.Interfaces
{
    public interface ITextDataProcessingStrategy
    {
        string ProcessingResultDescription { get; }
        string ProcessData(string data);
	}
}

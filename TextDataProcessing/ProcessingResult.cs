using TextFileProcessing.Attributes;

namespace TextFileProcessing.TextDataProcessing
{
    public class ProcessingResult
    {
		public string ProcessingResultDescription { get; }
		public string Result { get; }

		public ProcessingResult(string processingResultDescription, string result)
		{
			this.ProcessingResultDescription = processingResultDescription;
			this.Result = result;
		}
	}
}

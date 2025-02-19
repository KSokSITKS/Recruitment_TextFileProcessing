using TextFileProcessing.TextDataProcessing;

namespace TextFileProcessing
{
	public class CheckedListBoxItem
	{
		public TextDataProcessingStrategyType Value { get; }
		public string DisplayName { get; }

		public CheckedListBoxItem(TextDataProcessingStrategyType value, string displayName)
		{
			Value = value;
			DisplayName = displayName;
		}

		public override string ToString()
		{
			return DisplayName;
		}
	}
}

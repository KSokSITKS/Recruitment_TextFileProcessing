using TextFileProcessing.Attributes;

namespace TextFileProcessing.TextDataProcessing
{
	public enum TextDataProcessingStrategyType
	{
		[Name("Licznik słów")]
		WordsCounter,
		[Name("Licznik zdań")]
		SentencesCounter,
		[Name("Licznik znaków")]
		CharactersCounter
	}
}

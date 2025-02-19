using System;
using System.IO;
using TextFileProcessing.Exceptions;

namespace TextFileProcessing.TextDataLoader
{
	public class TextDataFromDiscFileProvider : ITextDataProvider
	{
		private readonly string filePath;

		public TextDataFromDiscFileProvider(string filePath)
		{
			this.filePath = filePath;
		}

		public string GetTextData()
		{
			if (string.IsNullOrWhiteSpace(this.filePath))
				throw new TextFileProcessingInvalidArgumentException("Ścieżka do pliku nie może być pusta");

			if (!File.Exists(this.filePath))
				throw new TextFileProcessingInvalidArgumentException("Plik nie istnieje");

			return File.ReadAllText(this.filePath);
		}
	}
}

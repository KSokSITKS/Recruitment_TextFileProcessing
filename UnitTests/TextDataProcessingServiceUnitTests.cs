using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TextFileProcessing.TextDataLoader;
using TextFileProcessing.TextDataProcessing;
using TextFileProcessing.TextDataProcessing.Interfaces;

namespace UnitTests
{
	[TestClass]
	public class TextDataProcessingServiceUnitTests
	{
		private Mock<ITextDataProvider> dataProviderMock;

		[TestInitialize]
		public void Setup()
		{
			this.dataProviderMock = new Mock<ITextDataProvider>();
			this.dataProviderMock
				.Setup(dp => dp.GetTextData())
				.Returns("Test data");
		}

		[TestMethod]
		public async Task Should_ReturnEmptyList_When_NoStrategiesProvided()
		{
			var service = new TextDataProcessingService();
			var strategies = new List<ITextDataProcessingStrategy>();
			var results = await service.ProcessData(dataProviderMock.Object, strategies);

			Assert.AreEqual(0, results.Count);
		}

		[TestMethod]
		public async Task Should_ProcessDataWithMultipleStrategies_When_StrategiesProvided()
		{
			var strategyMock1 = new Mock<ITextDataProcessingStrategy>();
			strategyMock1
				.Setup(s => s.ProcessingResultDescription)
				.Returns("Strategy 1");
			strategyMock1
				.Setup(s => s.ProcessData(It.IsAny<string>()))
				.Returns("Result 1");

			var strategyMock2 = new Mock<ITextDataProcessingStrategy>();
			strategyMock2
				.Setup(s => s.ProcessingResultDescription)
				.Returns("Strategy 2");
			strategyMock2
				.Setup(s => s.ProcessData(It.IsAny<string>()))
				.Returns("Result 2");

			var service = new TextDataProcessingService();
			var strategies = new List<ITextDataProcessingStrategy> { strategyMock1.Object, strategyMock2.Object };
			var results = await service.ProcessData(dataProviderMock.Object, strategies);

			Assert.AreEqual(2, results.Count);
			Assert.AreEqual("Strategy 1", results[0].ProcessingResultDescription);
			Assert.AreEqual("Result 1", results[0].Result);
			Assert.AreEqual("Strategy 2", results[1].ProcessingResultDescription);
			Assert.AreEqual("Result 2", results[1].Result);
		}
	}
}


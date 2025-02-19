using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TextFileProcessing.Extensions;
using TextFileProcessing.TextDataLoader;
using TextFileProcessing.TextDataProcessing;
using TextFileProcessing.TextDataProcessing.Interfaces;

namespace TextFileProcessing
{
    public partial class MainWindow: Form
    {
		private readonly ITextDataProcessingService textDataProcessingService;
		private readonly ITextDataProcessingStrategiesListFactory textDataProcessingStrategiesListFactory;

		public MainWindow(
			ITextDataProcessingService textDataProcessingService,
			ITextDataProcessingStrategiesListFactory textDataProcessingStrategiesListFactory
			)
        {
			this.textDataProcessingService = textDataProcessingService;
			this.textDataProcessingStrategiesListFactory = textDataProcessingStrategiesListFactory;

			InitializeComponent();
			PopulateCheckedListBox();
			InitializeDataGridView();
		}

		private void btnFileSearch_Click(object sender, EventArgs e)
		{
			using (var openFileDialog = new OpenFileDialog())
			{
				openFileDialog.InitialDirectory = "c:\\";
				openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
				openFileDialog.FilterIndex = 1;
				openFileDialog.RestoreDirectory = true;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					string filePath = openFileDialog.FileName;
					
					this.txtFilePath.Text = filePath;
				}
			}
		}

		private async void btnProcessFile_Click(object sender, EventArgs e)
		{
			var textDataProvider = new TextDataFromDiscFileProvider(this.txtFilePath.Text);
			var processingStrategiesSelected = this.GetProcessingStrategyTypes();
			var processingStrategies = this.textDataProcessingStrategiesListFactory.Create(processingStrategiesSelected);

			var processingResults = await this.textDataProcessingService.ProcessData(textDataProvider, processingStrategies);

			this.dgProcessingResults.DataSource = new BindingSource { DataSource = processingResults };
		}

		private List<TextDataProcessingStrategyType> GetProcessingStrategyTypes()
		{
			return chklbStrategyTypesSelection.CheckedItems
				.Cast<CheckedListBoxItem>()
				.Select(item => item.Value)
				.ToList();
		}

		private void PopulateCheckedListBox()
		{
			foreach (TextDataProcessingStrategyType strategy in Enum.GetValues(typeof(TextDataProcessingStrategyType)))
			{
				var displayName = strategy.GetName();

				chklbStrategyTypesSelection.Items.Add(new CheckedListBoxItem(strategy, displayName));
			}
		}

		private void InitializeDataGridView()
		{
			this.dgProcessingResults.AllowUserToAddRows = false;
			this.dgProcessingResults.AllowUserToDeleteRows = false;
			this.dgProcessingResults.ReadOnly = true;
			this.dgProcessingResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

			this.dgProcessingResults.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "ProcessingResultDescription",
				HeaderText = "Opis przetwarzania",
				Name = "Description",
				AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			});

			this.dgProcessingResults.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "Result",
				HeaderText = "Wynik przetwarzania",
				Name = "Result",
				AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			});
		}
	}
}

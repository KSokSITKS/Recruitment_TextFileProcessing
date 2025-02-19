namespace TextFileProcessing
{
	partial class MainWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblFilePath = new System.Windows.Forms.Label();
			this.txtFilePath = new System.Windows.Forms.TextBox();
			this.btnFileSearch = new System.Windows.Forms.Button();
			this.btnProcessFile = new System.Windows.Forms.Button();
			this.dgProcessingResults = new System.Windows.Forms.DataGridView();
			this.lblProcessingSummary = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgProcessingResults)).BeginInit();
			this.SuspendLayout();
			// 
			// lblFilePath
			// 
			this.lblFilePath.AutoSize = true;
			this.lblFilePath.Location = new System.Drawing.Point(12, 16);
			this.lblFilePath.Name = "lblFilePath";
			this.lblFilePath.Size = new System.Drawing.Size(85, 13);
			this.lblFilePath.TabIndex = 0;
			this.lblFilePath.Text = "Ścieżka do pliku";
			// 
			// txtFilePath
			// 
			this.txtFilePath.Location = new System.Drawing.Point(105, 13);
			this.txtFilePath.Name = "txtFilePath";
			this.txtFilePath.Size = new System.Drawing.Size(435, 20);
			this.txtFilePath.TabIndex = 1;
			// 
			// btnFileSearch
			// 
			this.btnFileSearch.Location = new System.Drawing.Point(547, 13);
			this.btnFileSearch.Name = "btnFileSearch";
			this.btnFileSearch.Size = new System.Drawing.Size(138, 23);
			this.btnFileSearch.TabIndex = 2;
			this.btnFileSearch.Text = "Wybierz plik tekstowy";
			this.btnFileSearch.UseVisualStyleBackColor = true;
			this.btnFileSearch.Click += new System.EventHandler(this.btnFileSearch_Click);
			// 
			// btnProcessFile
			// 
			this.btnProcessFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProcessFile.Location = new System.Drawing.Point(13, 65);
			this.btnProcessFile.Name = "btnProcessFile";
			this.btnProcessFile.Size = new System.Drawing.Size(163, 42);
			this.btnProcessFile.TabIndex = 3;
			this.btnProcessFile.Text = "Przetwarzaj plik";
			this.btnProcessFile.UseVisualStyleBackColor = true;
			this.btnProcessFile.Click += new System.EventHandler(this.btnProcessFile_Click);
			// 
			// dgProcessingResults
			// 
			this.dgProcessingResults.AllowUserToAddRows = false;
			this.dgProcessingResults.AllowUserToDeleteRows = false;
			this.dgProcessingResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgProcessingResults.Location = new System.Drawing.Point(15, 174);
			this.dgProcessingResults.Name = "dgProcessingResults";
			this.dgProcessingResults.ReadOnly = true;
			this.dgProcessingResults.Size = new System.Drawing.Size(773, 264);
			this.dgProcessingResults.TabIndex = 4;
			// 
			// lblProcessingSummary
			// 
			this.lblProcessingSummary.AutoSize = true;
			this.lblProcessingSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProcessingSummary.Location = new System.Drawing.Point(12, 138);
			this.lblProcessingSummary.Name = "lblProcessingSummary";
			this.lblProcessingSummary.Size = new System.Drawing.Size(238, 22);
			this.lblProcessingSummary.TabIndex = 5;
			this.lblProcessingSummary.Text = "Podumowanie przetwarzania";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblProcessingSummary);
			this.Controls.Add(this.dgProcessingResults);
			this.Controls.Add(this.btnProcessFile);
			this.Controls.Add(this.btnFileSearch);
			this.Controls.Add(this.txtFilePath);
			this.Controls.Add(this.lblFilePath);
			this.Name = "MainWindow";
			this.Text = "Text File Processing";
			((System.ComponentModel.ISupportInitialize)(this.dgProcessingResults)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblFilePath;
		private System.Windows.Forms.TextBox txtFilePath;
		private System.Windows.Forms.Button btnFileSearch;
		private System.Windows.Forms.Button btnProcessFile;
		private System.Windows.Forms.DataGridView dgProcessingResults;
		private System.Windows.Forms.Label lblProcessingSummary;
	}
}


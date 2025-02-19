using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileProcessing
{
    public partial class MainWindow: Form
    {
        public MainWindow()
        {
            InitializeComponent();
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
	}
}

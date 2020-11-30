using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Security;
using System.Collections.Generic;
using System.Collections;

namespace Temp_review
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        //variable declarations

        ArrayList temperature;
        String monthName;
        StreamReader InputFile;
        OpenFileDialog openFileDialog;
        int highTemp, lowTemp, averageTemp;

        private void btnFileSelect_Click(object sender, EventArgs e)
        {
            lblFilePath.Text = string.Empty;
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt) |*.txt|All Files(*.*)|*.*";
          
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    InputFile = new StreamReader(openFileDialog.FileName);
                    lblFilePath.Text = openFileDialog.FileName;

                }
                catch(SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message:{ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                }
            }
            
            
        }

        private void btnReportResults_Click(object sender, EventArgs e)
        {
            int tempInt;
            temperature = new ArrayList();
            monthName = InputFile.ReadLine();
            while (!InputFile.EndOfStream)
            {
                int.TryParse(InputFile.ReadLine(), out tempInt);
                temperature.Add(tempInt);
            }
           
        }
    }
}

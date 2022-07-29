using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using DateSeparator.Logic;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace DateSeparator
{
    public partial class Form1 : Form
    {
        private readonly ILogic logic;

        public Form1()
        {
            InitializeComponent();
            this.logic = new Logic.Logic();
            backgroundWorker.WorkerReportsProgress = true;
        }

        
        
        private void sourceButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            //dialog.InitialDirectory = Directory.GetCurrentDirectory();
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                sourceTextBox.Text = dialog.FileName;
            }
        }

        private void targetButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                targetTextBox.Text = dialog.FileName;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if(sourceTextBox.Text.Length != 0 && targetTextBox.Text.Length != 0)
            {
                startButton.Enabled = false;
                progressBar.Visible = true;
                warningLabel.Visible = true;
                percentageLabel.Visible = true;
                
                backgroundWorker.RunWorkerAsync();
                
            }
            else
            {
                MessageBox.Show("Please select the folders!");
            }
            
        }
        
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            startButton.Enabled = true;
            progressBar.Visible = false;
            warningLabel.Visible = false;
            percentageLabel.Visible = false;

            progressBar.Value = 0;
            percentageLabel.Text = 0 + "%";
            MessageBox.Show("Operation is completed");
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string targetPath = targetTextBox.Text;

            var sourcePath = sourceTextBox.Text;

            if (everyMonthRadioButton.Checked)
            {
                this.logic.CopyIntoEveryMonth(sourcePath,targetPath);

            }else if (every3MonthRadioButton.Checked)
            {
                this.logic.CopyIntoEvery3Month(sourcePath, targetPath);
            }else if (yearRadioButton.Checked)
            {
                this.logic.CopyIntoYears(sourcePath, targetPath);
            }
           
            
            
     
        }
        
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            percentageLabel.Text = e.ProgressPercentage + "%";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace DateSeparator
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            //dialog.InitialDirectory = Directory.GetCurrentDirectory();
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                textBox1.Text = dialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                textBox2.Text = dialog.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length != 0 || textBox2.Text.Length != 0)
            {
                button3.Enabled = false;
                progressBar.Visible = true;
                warningLabel.Visible = true;
                backgroundWorker.RunWorkerAsync();
                
            }
            else
            {
                MessageBox.Show("Please select the folders!");
            }
            
        }
        public void CreateFile(String path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);

            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            button3.Enabled = true;
            progressBar.Visible = false;
            warningLabel.Visible = false;
            MessageBox.Show("Operation is completed");
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string targetDirectory = textBox2.Text;
            CreateFile(targetDirectory);

            var filesPath = textBox1.Text;
            var filesToHandle = new DirectoryInfo(filesPath);


            var files = filesToHandle.GetFiles();


            foreach (var fileInfo in files)
            {
                //Console.WriteLine(fileInfo + " and the creation date is ; " + fileInfo.LastWriteTime);


                var newTargetWithYearAndMonth = targetDirectory + @"\" + fileInfo.LastWriteTime.Year + @"\" + fileInfo.LastWriteTime.Month;
                CreateFile(newTargetWithYearAndMonth);
                File.Copy(filesPath + @"\" + fileInfo.Name, newTargetWithYearAndMonth + @"\" + fileInfo.Name);

                //Console.WriteLine();
            }

            var directories = filesToHandle.GetDirectories();
            while (directories.Length != 0)
            {

            }

        }

        public void SubDirectoryChecker()
        {

        }

        
    }
}

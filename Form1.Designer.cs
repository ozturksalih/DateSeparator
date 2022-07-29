
namespace DateSeparator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sourceLabel = new System.Windows.Forms.Label();
            this.targetLabel = new System.Windows.Forms.Label();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.sourceButton = new System.Windows.Forms.Button();
            this.targetButton = new System.Windows.Forms.Button();
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            Form1.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.warningLabel = new System.Windows.Forms.Label();
            this.everyMonthRadioButton = new System.Windows.Forms.RadioButton();
            this.every3MonthRadioButton = new System.Windows.Forms.RadioButton();
            this.yearRadioButton = new System.Windows.Forms.RadioButton();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.sourceLabel.Location = new System.Drawing.Point(71, 42);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(225, 41);
            this.sourceLabel.TabIndex = 0;
            this.sourceLabel.Text = "Path of Source ;";
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.targetLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.targetLabel.Location = new System.Drawing.Point(71, 107);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(224, 41);
            this.targetLabel.TabIndex = 1;
            this.targetLabel.Text = "Path of Target  ;";
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sourceTextBox.Location = new System.Drawing.Point(302, 53);
            this.sourceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(371, 30);
            this.sourceTextBox.TabIndex = 4;
            // 
            // sourceButton
            // 
            this.sourceButton.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.sourceButton.Location = new System.Drawing.Point(679, 48);
            this.sourceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sourceButton.Name = "sourceButton";
            this.sourceButton.Size = new System.Drawing.Size(54, 41);
            this.sourceButton.TabIndex = 5;
            this.sourceButton.Text = "●●●";
            this.sourceButton.UseVisualStyleBackColor = true;
            this.sourceButton.Click += new System.EventHandler(this.sourceButton_Click);
            // 
            // targetButton
            // 
            this.targetButton.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.targetButton.Location = new System.Drawing.Point(679, 105);
            this.targetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.targetButton.Name = "targetButton";
            this.targetButton.Size = new System.Drawing.Size(54, 41);
            this.targetButton.TabIndex = 7;
            this.targetButton.Text = "●●●";
            this.targetButton.UseVisualStyleBackColor = true;
            this.targetButton.Click += new System.EventHandler(this.targetButton_Click);
            // 
            // targetTextBox
            // 
            this.targetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.targetTextBox.Location = new System.Drawing.Point(302, 110);
            this.targetTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.Size = new System.Drawing.Size(371, 30);
            this.targetTextBox.TabIndex = 6;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.startButton.Location = new System.Drawing.Point(725, 197);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(121, 54);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(318, 213);
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(300, 28);
            this.progressBar.TabIndex = 9;
            this.progressBar.Visible = false;
            //
            // backgroundWorker
            // 
            Form1.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            Form1.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            Form1.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(300, 254);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(339, 36);
            this.warningLabel.TabIndex = 10;
            this.warningLabel.Text = "Wait until succedd message ";
            this.warningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.warningLabel.Visible = false;
            // 
            // everyMonthRadioButton
            // 
            this.everyMonthRadioButton.AutoSize = true;
            this.everyMonthRadioButton.Checked = true;
            this.everyMonthRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.everyMonthRadioButton.Location = new System.Drawing.Point(89, 169);
            this.everyMonthRadioButton.Name = "everyMonthRadioButton";
            this.everyMonthRadioButton.Size = new System.Drawing.Size(170, 33);
            this.everyMonthRadioButton.TabIndex = 12;
            this.everyMonthRadioButton.TabStop = true;
            this.everyMonthRadioButton.Text = "Every Month";
            this.everyMonthRadioButton.UseVisualStyleBackColor = true;
            // 
            // every3MonthRadioButton
            // 
            this.every3MonthRadioButton.AutoSize = true;
            this.every3MonthRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.every3MonthRadioButton.Location = new System.Drawing.Point(89, 208);
            this.every3MonthRadioButton.Name = "every3MonthRadioButton";
            this.every3MonthRadioButton.Size = new System.Drawing.Size(189, 33);
            this.every3MonthRadioButton.TabIndex = 13;
            this.every3MonthRadioButton.Text = "Every 3 Month";
            this.every3MonthRadioButton.UseVisualStyleBackColor = true;
            // 
            // yearRadioButton
            // 
            this.yearRadioButton.AutoSize = true;
            this.yearRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.yearRadioButton.Location = new System.Drawing.Point(89, 247);
            this.yearRadioButton.Name = "yearRadioButton";
            this.yearRadioButton.Size = new System.Drawing.Size(145, 33);
            this.yearRadioButton.TabIndex = 14;
            this.yearRadioButton.Text = "Just years";
            this.yearRadioButton.UseVisualStyleBackColor = true;
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.percentageLabel.Location = new System.Drawing.Point(635, 221);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(41, 25);
            this.percentageLabel.TabIndex = 15;
            this.percentageLabel.Text = "0%";
            this.percentageLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 437);
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.yearRadioButton);
            this.Controls.Add(this.every3MonthRadioButton);
            this.Controls.Add(this.everyMonthRadioButton);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.targetButton);
            this.Controls.Add(this.targetTextBox);
            this.Controls.Add(this.sourceButton);
            this.Controls.Add(this.sourceTextBox);
            this.Controls.Add(this.targetLabel);
            this.Controls.Add(this.sourceLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Date Separator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.Button sourceButton;
        private System.Windows.Forms.Button targetButton;
        private System.Windows.Forms.TextBox targetTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ProgressBar progressBar;
        public static System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.RadioButton everyMonthRadioButton;
        private System.Windows.Forms.RadioButton every3MonthRadioButton;
        private System.Windows.Forms.RadioButton yearRadioButton;
        private System.Windows.Forms.Label percentageLabel;
    }
}


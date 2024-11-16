﻿namespace WinBackgroundWorker
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            button2 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 15);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Second to sleep";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 40);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Progress";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 12);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(70, 23);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress_1;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.Lavender;
            progressBar1.Location = new Point(105, 40);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(240, 20);
            progressBar1.TabIndex = 3;
            progressBar1.Click += progressBar1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lavender;
            button1.Location = new Point(195, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 4;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lavender;
            button2.Location = new Point(270, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 25);
            button2.TabIndex = 5;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(354, 71);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinBackgroundWorker";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ProgressBar progressBar1;
        private Button button1;
        private Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
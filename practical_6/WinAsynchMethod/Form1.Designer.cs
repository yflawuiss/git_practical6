namespace WinAsynchMethod
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
            btnRun = new Button();
            btnWork = new Button();
            lblA = new Label();
            lblB = new Label();
            tbxA = new TextBox();
            tbxB = new TextBox();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.BackColor = Color.Lavender;
            btnRun.ForeColor = Color.Indigo;
            btnRun.Location = new Point(16, 128);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(75, 23);
            btnRun.TabIndex = 3;
            btnRun.Text = "Добуток";
            btnRun.UseVisualStyleBackColor = false;
            btnRun.Click += btnRun_Click;
            // 
            // btnWork
            // 
            btnWork.BackColor = Color.Lavender;
            btnWork.ForeColor = Color.Indigo;
            btnWork.Location = new Point(120, 128);
            btnWork.Name = "btnWork";
            btnWork.Size = new Size(75, 23);
            btnWork.TabIndex = 4;
            btnWork.Text = "Робота";
            btnWork.UseVisualStyleBackColor = false;
            btnWork.Click += btnWork_Click;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.ForeColor = Color.Indigo;
            lblA.Location = new Point(8, 8);
            lblA.Name = "lblA";
            lblA.Size = new Size(71, 15);
            lblA.TabIndex = 2;
            lblA.Text = "Значення А";
            lblA.Click += lblA_Click;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.ForeColor = Color.Indigo;
            lblB.Location = new Point(164, 8);
            lblB.Name = "lblB";
            lblB.Size = new Size(70, 15);
            lblB.TabIndex = 3;
            lblB.Text = "Значення В";
            lblB.Click += lblB_Click;
            // 
            // tbxA
            // 
            tbxA.Location = new Point(8, 25);
            tbxA.Name = "tbxA";
            tbxA.Size = new Size(100, 23);
            tbxA.TabIndex = 1;
            tbxA.TextChanged += tbxA_TextChanged;
            // 
            // tbxB
            // 
            tbxB.Location = new Point(164, 25);
            tbxB.Name = "tbxB";
            tbxB.Size = new Size(100, 23);
            tbxB.TabIndex = 2;
            tbxB.TextChanged += tbxB_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(272, 161);
            Controls.Add(tbxB);
            Controls.Add(tbxA);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(btnWork);
            Controls.Add(btnRun);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.ControlText;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Асинхронний запуск";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRun;
        private Button btnWork;
        private Label lblA;
        private Label lblB;
        private TextBox tbxA;
        private TextBox tbxB;
    }
}

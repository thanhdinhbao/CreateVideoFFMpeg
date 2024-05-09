namespace CreateVideo
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
            button1 = new Button();
            txtFolderPath = new TextBox();
            button2 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(80, 268);
            button1.Name = "button1";
            button1.Size = new Size(111, 63);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtFolderPath
            // 
            txtFolderPath.Location = new Point(22, 98);
            txtFolderPath.Name = "txtFolderPath";
            txtFolderPath.Size = new Size(180, 23);
            txtFolderPath.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(208, 96);
            button2.Name = "button2";
            button2.Size = new Size(50, 26);
            button2.TabIndex = 2;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 450);
            Controls.Add(button2);
            Controls.Add(txtFolderPath);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Click += button1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtFolderPath;
        private Button button2;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
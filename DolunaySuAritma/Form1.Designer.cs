﻿namespace DolunaySuAritma
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
            bakimFormuBtn = new Button();
            SuspendLayout();
            // 
            // bakimFormuBtn
            // 
            bakimFormuBtn.Location = new Point(307, 185);
            bakimFormuBtn.Name = "bakimFormuBtn";
            bakimFormuBtn.Size = new Size(94, 29);
            bakimFormuBtn.TabIndex = 0;
            bakimFormuBtn.Text = "Bakım Formları";
            bakimFormuBtn.UseVisualStyleBackColor = true;
            bakimFormuBtn.Click += bakimFormuBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 21, 37);
            ClientSize = new Size(1210, 632);
            Controls.Add(bakimFormuBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button bakimFormuBtn;
    }
}

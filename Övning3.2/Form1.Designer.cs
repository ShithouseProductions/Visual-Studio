﻿namespace Övning3._2
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
            this.lblTal1 = new System.Windows.Forms.Label();
            this.lblTal2 = new System.Windows.Forms.Label();
            this.lblSumma = new System.Windows.Forms.Label();
            this.tbxTal1 = new System.Windows.Forms.TextBox();
            this.tbxTal2 = new System.Windows.Forms.TextBox();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTal1
            // 
            this.lblTal1.AutoSize = true;
            this.lblTal1.Location = new System.Drawing.Point(41, 55);
            this.lblTal1.Name = "lblTal1";
            this.lblTal1.Size = new System.Drawing.Size(30, 15);
            this.lblTal1.TabIndex = 0;
            this.lblTal1.Text = "Tal 1";
            // 
            // lblTal2
            // 
            this.lblTal2.AutoSize = true;
            this.lblTal2.Location = new System.Drawing.Point(41, 104);
            this.lblTal2.Name = "lblTal2";
            this.lblTal2.Size = new System.Drawing.Size(30, 15);
            this.lblTal2.TabIndex = 0;
            this.lblTal2.Text = "Tal 2";
            // 
            // lblSumma
            // 
            this.lblSumma.AutoSize = true;
            this.lblSumma.Location = new System.Drawing.Point(41, 169);
            this.lblSumma.Name = "lblSumma";
            this.lblSumma.Size = new System.Drawing.Size(38, 15);
            this.lblSumma.TabIndex = 0;
            this.lblSumma.Text = "label3";
            // 
            // tbxTal1
            // 
            this.tbxTal1.Location = new System.Drawing.Point(119, 52);
            this.tbxTal1.Name = "tbxTal1";
            this.tbxTal1.Size = new System.Drawing.Size(100, 23);
            this.tbxTal1.TabIndex = 1;
            // 
            // tbxTal2
            // 
            this.tbxTal2.Location = new System.Drawing.Point(119, 104);
            this.tbxTal2.Name = "tbxTal2";
            this.tbxTal2.Size = new System.Drawing.Size(100, 23);
            this.tbxTal2.TabIndex = 1;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(128, 194);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 2;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 264);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.tbxTal2);
            this.Controls.Add(this.tbxTal1);
            this.Controls.Add(this.lblSumma);
            this.Controls.Add(this.lblTal2);
            this.Controls.Add(this.lblTal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTal1;
        private System.Windows.Forms.Label lblTal2;
        private System.Windows.Forms.Label lblSumma;
        private System.Windows.Forms.TextBox tbxTal1;
        private System.Windows.Forms.TextBox tbxTal2;
        private System.Windows.Forms.Button btnKör;
    }
}


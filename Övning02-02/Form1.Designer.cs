namespace Övning02_02
{
    partial class Meddelande
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
            this.BtnMeddelande = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMeddelande
            // 
            this.BtnMeddelande.Location = new System.Drawing.Point(55, 77);
            this.BtnMeddelande.Name = "BtnMeddelande";
            this.BtnMeddelande.Size = new System.Drawing.Size(81, 23);
            this.BtnMeddelande.TabIndex = 0;
            this.BtnMeddelande.Text = "Meddelande";
            this.BtnMeddelande.UseVisualStyleBackColor = true;
            this.BtnMeddelande.Click += new System.EventHandler(this.BtnMeddelande_Click);
            // 
            // Meddelande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.BtnMeddelande);
            this.Name = "Meddelande";
            this.Text = "Övning";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMeddelande;
    }
}


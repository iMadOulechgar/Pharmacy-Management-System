namespace Pharmacy_Management_System.Drug
{
    partial class FrmShowDrugInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ctrlShowDrugInfo1 = new Pharmacy_Management_System.Drug.Controles.CtrlShowDrugInfo();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(233, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(177, 28);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Drug Information";
            // 
            // ctrlShowDrugInfo1
            // 
            this.ctrlShowDrugInfo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrlShowDrugInfo1.Location = new System.Drawing.Point(12, 46);
            this.ctrlShowDrugInfo1.Name = "ctrlShowDrugInfo1";
            this.ctrlShowDrugInfo1.Size = new System.Drawing.Size(625, 259);
            this.ctrlShowDrugInfo1.TabIndex = 1;
            // 
            // FrmShowDrugInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(652, 317);
            this.Controls.Add(this.ctrlShowDrugInfo1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmShowDrugInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DrugInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Controles.CtrlShowDrugInfo ctrlShowDrugInfo1;
    }
}
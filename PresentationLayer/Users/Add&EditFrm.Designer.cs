namespace Pharmacy_Management_System.Users
{
    partial class Add_EditFrm
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
            this.LBLTitle = new System.Windows.Forms.Label();
            this.addAndEditUserCtl1 = new Pharmacy_Management_System.Users.Controles.AddAndEditUserCtl();
            this.SuspendLayout();
            // 
            // LBLTitle
            // 
            this.LBLTitle.AutoSize = true;
            this.LBLTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LBLTitle.Location = new System.Drawing.Point(307, 9);
            this.LBLTitle.Name = "LBLTitle";
            this.LBLTitle.Size = new System.Drawing.Size(154, 30);
            this.LBLTitle.TabIndex = 3;
            this.LBLTitle.Text = "Add New User";
            // 
            // addAndEditUserCtl1
            // 
            this.addAndEditUserCtl1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addAndEditUserCtl1.Location = new System.Drawing.Point(12, 49);
            this.addAndEditUserCtl1.Name = "addAndEditUserCtl1";
            this.addAndEditUserCtl1.Size = new System.Drawing.Size(766, 349);
            this.addAndEditUserCtl1.TabIndex = 4;
            this.addAndEditUserCtl1.Load += new System.EventHandler(this.addAndEditUserCtl1_Load);
            // 
            // Add_EditFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(793, 412);
            this.Controls.Add(this.addAndEditUserCtl1);
            this.Controls.Add(this.LBLTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Add_EditFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Add_EditFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLTitle;
        private Controles.AddAndEditUserCtl addAndEditUserCtl1;
    }
}
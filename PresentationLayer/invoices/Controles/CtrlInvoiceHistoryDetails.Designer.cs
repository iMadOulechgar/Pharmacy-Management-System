namespace Pharmacy_Management_System.History.Controles
{
    partial class CtrlInvoiceHistoryDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserPic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LBLUsername = new System.Windows.Forms.Label();
            this.LBLDesc = new System.Windows.Forms.Label();
            this.LBLTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserPic)).BeginInit();
            this.SuspendLayout();
            // 
            // UserPic
            // 
            this.UserPic.BackColor = System.Drawing.Color.Transparent;
            this.UserPic.Location = new System.Drawing.Point(10, 8);
            this.UserPic.Name = "UserPic";
            this.UserPic.ShadowDecoration.Parent = this.UserPic;
            this.UserPic.Size = new System.Drawing.Size(69, 55);
            this.UserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPic.TabIndex = 0;
            this.UserPic.TabStop = false;
            // 
            // LBLUsername
            // 
            this.LBLUsername.AutoSize = true;
            this.LBLUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUsername.Location = new System.Drawing.Point(106, 8);
            this.LBLUsername.Name = "LBLUsername";
            this.LBLUsername.Size = new System.Drawing.Size(87, 20);
            this.LBLUsername.TabIndex = 3;
            this.LBLUsername.Text = "User Name";
            // 
            // LBLDesc
            // 
            this.LBLDesc.AutoSize = true;
            this.LBLDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDesc.Location = new System.Drawing.Point(107, 48);
            this.LBLDesc.Name = "LBLDesc";
            this.LBLDesc.Size = new System.Drawing.Size(68, 15);
            this.LBLDesc.TabIndex = 3;
            this.LBLDesc.Text = "Description";
            // 
            // LBLTime
            // 
            this.LBLTime.AutoSize = true;
            this.LBLTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTime.Location = new System.Drawing.Point(424, 29);
            this.LBLTime.Name = "LBLTime";
            this.LBLTime.Size = new System.Drawing.Size(34, 15);
            this.LBLTime.TabIndex = 3;
            this.LBLTime.Text = "Time";
            // 
            // CtrlInvoiceHistoryDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.LBLTime);
            this.Controls.Add(this.LBLDesc);
            this.Controls.Add(this.LBLUsername);
            this.Controls.Add(this.UserPic);
            this.Name = "CtrlInvoiceHistoryDetails";
            this.Size = new System.Drawing.Size(592, 73);
            ((System.ComponentModel.ISupportInitialize)(this.UserPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox UserPic;
        private System.Windows.Forms.Label LBLUsername;
        private System.Windows.Forms.Label LBLDesc;
        private System.Windows.Forms.Label LBLTime;
    }
}

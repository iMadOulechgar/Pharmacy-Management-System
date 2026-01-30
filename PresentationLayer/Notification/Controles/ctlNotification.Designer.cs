namespace Pharmacy_Management_System.Notification.Controles
{
    partial class ctlNotification
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBLTime = new System.Windows.Forms.Label();
            this.LBLTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBLDesc = new System.Windows.Forms.Label();
            this.LBLDelete = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacy_Management_System.Properties.Resources.icons8_drugs_48;
            this.pictureBox1.Location = new System.Drawing.Point(3, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LBLTime
            // 
            this.LBLTime.AutoSize = true;
            this.LBLTime.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTime.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LBLTime.Location = new System.Drawing.Point(341, 13);
            this.LBLTime.Name = "LBLTime";
            this.LBLTime.Size = new System.Drawing.Size(58, 15);
            this.LBLTime.TabIndex = 1;
            this.LBLTime.Text = "Just Now";
            // 
            // LBLTitle
            // 
            this.LBLTitle.AutoSize = true;
            this.LBLTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTitle.ForeColor = System.Drawing.Color.Black;
            this.LBLTitle.Location = new System.Drawing.Point(89, 14);
            this.LBLTitle.Name = "LBLTitle";
            this.LBLTitle.Size = new System.Drawing.Size(38, 19);
            this.LBLTitle.TabIndex = 2;
            this.LBLTitle.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 14);
            this.label1.TabIndex = 2;
            // 
            // LBLDesc
            // 
            this.LBLDesc.AutoSize = true;
            this.LBLDesc.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDesc.ForeColor = System.Drawing.Color.Black;
            this.LBLDesc.Location = new System.Drawing.Point(89, 46);
            this.LBLDesc.Name = "LBLDesc";
            this.LBLDesc.Size = new System.Drawing.Size(79, 17);
            this.LBLDesc.TabIndex = 2;
            this.LBLDesc.Text = "Description";
            // 
            // LBLDelete
            // 
            this.LBLDelete.AutoSize = true;
            this.LBLDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDelete.LinkColor = System.Drawing.Color.Red;
            this.LBLDelete.Location = new System.Drawing.Point(361, 54);
            this.LBLDelete.Name = "LBLDelete";
            this.LBLDelete.Size = new System.Drawing.Size(49, 15);
            this.LBLDelete.TabIndex = 3;
            this.LBLDelete.TabStop = true;
            this.LBLDelete.Text = "Delete";
            // 
            // ctlNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.LBLDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBLDesc);
            this.Controls.Add(this.LBLTitle);
            this.Controls.Add(this.LBLTime);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ctlNotification";
            this.Size = new System.Drawing.Size(412, 77);
            this.Load += new System.EventHandler(this.ctlNotification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBLTime;
        private System.Windows.Forms.Label LBLTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLDesc;
        private System.Windows.Forms.LinkLabel LBLDelete;
    }
}

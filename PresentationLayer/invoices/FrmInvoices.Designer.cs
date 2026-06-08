namespace Pharmacy_Management_System.Drug
{
    partial class FrmInvoices
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
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.BTNSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.LayoutPanelInVoices = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel1.Location = new System.Drawing.Point(461, 7);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(147, 52);
            this.reflectionLabel1.TabIndex = 8;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Invoices </i><font color=\"#B02B2C\">Info</font></font></b>";
            // 
            // BTNSave
            // 
            this.BTNSave.BorderRadius = 5;
            this.BTNSave.CheckedState.Parent = this.BTNSave;
            this.BTNSave.CustomImages.Parent = this.BTNSave;
            this.BTNSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BTNSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSave.ForeColor = System.Drawing.Color.White;
            this.BTNSave.HoverState.Parent = this.BTNSave;
            this.BTNSave.Location = new System.Drawing.Point(929, 452);
            this.BTNSave.Name = "BTNSave";
            this.BTNSave.ShadowDecoration.Parent = this.BTNSave;
            this.BTNSave.Size = new System.Drawing.Size(147, 45);
            this.BTNSave.TabIndex = 10;
            this.BTNSave.Text = "invoice Now";
            this.BTNSave.Click += new System.EventHandler(this.BTNSave_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(776, 452);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(147, 45);
            this.guna2Button1.TabIndex = 10;
            this.guna2Button1.Text = "Cancel";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // LayoutPanelInVoices
            // 
            this.LayoutPanelInVoices.AutoScroll = true;
            this.LayoutPanelInVoices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LayoutPanelInVoices.Location = new System.Drawing.Point(12, 65);
            this.LayoutPanelInVoices.Name = "LayoutPanelInVoices";
            this.LayoutPanelInVoices.Size = new System.Drawing.Size(1061, 381);
            this.LayoutPanelInVoices.TabIndex = 11;
            // 
            // FrmInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 506);
            this.Controls.Add(this.LayoutPanelInVoices);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.BTNSave);
            this.Controls.Add(this.reflectionLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmInvoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.FrmInvoices_Load);
            this.Leave += new System.EventHandler(this.FrmInvoices_Leave);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private Guna.UI2.WinForms.Guna2Button BTNSave;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanelInVoices;
    }
}
namespace Pharmacy_Management_System.Drug
{
    partial class FrmManageDrugs
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVDrugs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.LBLExpiredDrugs1 = new System.Windows.Forms.Label();
            this.LBLExpiredDrugs2 = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LBLSumDrugs1 = new System.Windows.Forms.Label();
            this.LBLSumDrugs2 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.LBLAvailableDrugs1 = new System.Windows.Forms.Label();
            this.LBLAvailableDrugs2 = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDrugInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editDrugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDrugs)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVDrugs
            // 
            this.DGVDrugs.AllowUserToAddRows = false;
            this.DGVDrugs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVDrugs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDrugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDrugs.BackgroundColor = System.Drawing.Color.Silver;
            this.DGVDrugs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVDrugs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVDrugs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDrugs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDrugs.ColumnHeadersHeight = 40;
            this.DGVDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVDrugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDrugs.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVDrugs.EnableHeadersVisualStyles = false;
            this.DGVDrugs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVDrugs.Location = new System.Drawing.Point(12, 163);
            this.DGVDrugs.Name = "DGVDrugs";
            this.DGVDrugs.ReadOnly = true;
            this.DGVDrugs.RowHeadersVisible = false;
            this.DGVDrugs.RowHeadersWidth = 30;
            this.DGVDrugs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDrugs.Size = new System.Drawing.Size(897, 398);
            this.DGVDrugs.TabIndex = 7;
            this.DGVDrugs.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DGVDrugs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVDrugs.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVDrugs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVDrugs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVDrugs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVDrugs.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.DGVDrugs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVDrugs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVDrugs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVDrugs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVDrugs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVDrugs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVDrugs.ThemeStyle.HeaderStyle.Height = 40;
            this.DGVDrugs.ThemeStyle.ReadOnly = true;
            this.DGVDrugs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVDrugs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVDrugs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVDrugs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVDrugs.ThemeStyle.RowsStyle.Height = 22;
            this.DGVDrugs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVDrugs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 12;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.linkLabel1);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.LBLExpiredDrugs1);
            this.guna2Panel2.Controls.Add(this.LBLExpiredDrugs2);
            this.guna2Panel2.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel2.FillColor = System.Drawing.Color.DarkSlateGray;
            this.guna2Panel2.Location = new System.Drawing.Point(313, 12);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(295, 84);
            this.guna2Panel2.TabIndex = 6;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gainsboro;
            this.linkLabel1.Location = new System.Drawing.Point(246, 63);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(39, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(74, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Son Expired Drugs";
            // 
            // LBLExpiredDrugs1
            // 
            this.LBLExpiredDrugs1.AutoSize = true;
            this.LBLExpiredDrugs1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLExpiredDrugs1.ForeColor = System.Drawing.Color.White;
            this.LBLExpiredDrugs1.Location = new System.Drawing.Point(73, 53);
            this.LBLExpiredDrugs1.Name = "LBLExpiredDrugs1";
            this.LBLExpiredDrugs1.Size = new System.Drawing.Size(44, 19);
            this.LBLExpiredDrugs1.TabIndex = 4;
            this.LBLExpiredDrugs1.Text = "Sum";
            // 
            // LBLExpiredDrugs2
            // 
            this.LBLExpiredDrugs2.AutoSize = true;
            this.LBLExpiredDrugs2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLExpiredDrugs2.ForeColor = System.Drawing.Color.White;
            this.LBLExpiredDrugs2.Location = new System.Drawing.Point(215, 35);
            this.LBLExpiredDrugs2.Name = "LBLExpiredDrugs2";
            this.LBLExpiredDrugs2.Size = new System.Drawing.Size(44, 19);
            this.LBLExpiredDrugs2.TabIndex = 4;
            this.LBLExpiredDrugs2.Text = "Sum";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::Pharmacy_Management_System.Properties.Resources.icons8_expired_100;
            this.guna2PictureBox2.Location = new System.Drawing.Point(19, 20);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(42, 43);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 0;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.guna2Panel1.BorderRadius = 12;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.linkLabel3);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.LBLSumDrugs1);
            this.guna2Panel1.Controls.Add(this.LBLSumDrugs2);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.FillColor = System.Drawing.Color.DarkSlateGray;
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(295, 84);
            this.guna2Panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Drugs";
            // 
            // LBLSumDrugs1
            // 
            this.LBLSumDrugs1.AutoSize = true;
            this.LBLSumDrugs1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSumDrugs1.ForeColor = System.Drawing.Color.White;
            this.LBLSumDrugs1.Location = new System.Drawing.Point(74, 53);
            this.LBLSumDrugs1.Name = "LBLSumDrugs1";
            this.LBLSumDrugs1.Size = new System.Drawing.Size(44, 19);
            this.LBLSumDrugs1.TabIndex = 4;
            this.LBLSumDrugs1.Text = "Sum";
            // 
            // LBLSumDrugs2
            // 
            this.LBLSumDrugs2.AutoSize = true;
            this.LBLSumDrugs2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSumDrugs2.ForeColor = System.Drawing.Color.White;
            this.LBLSumDrugs2.Location = new System.Drawing.Point(216, 35);
            this.LBLSumDrugs2.Name = "LBLSumDrugs2";
            this.LBLSumDrugs2.Size = new System.Drawing.Size(44, 19);
            this.LBLSumDrugs2.TabIndex = 4;
            this.LBLSumDrugs2.Text = "Sum";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Pharmacy_Management_System.Properties.Resources.icons8_drugs_48;
            this.guna2PictureBox1.Location = new System.Drawing.Point(19, 20);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(42, 43);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 12;
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.Controls.Add(this.linkLabel2);
            this.guna2Panel3.Controls.Add(this.label6);
            this.guna2Panel3.Controls.Add(this.LBLAvailableDrugs1);
            this.guna2Panel3.Controls.Add(this.LBLAvailableDrugs2);
            this.guna2Panel3.Controls.Add(this.guna2PictureBox3);
            this.guna2Panel3.FillColor = System.Drawing.Color.DarkSlateGray;
            this.guna2Panel3.Location = new System.Drawing.Point(614, 12);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(295, 84);
            this.guna2Panel3.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(74, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Available Drugs";
            // 
            // LBLAvailableDrugs1
            // 
            this.LBLAvailableDrugs1.AutoSize = true;
            this.LBLAvailableDrugs1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAvailableDrugs1.ForeColor = System.Drawing.Color.White;
            this.LBLAvailableDrugs1.Location = new System.Drawing.Point(74, 53);
            this.LBLAvailableDrugs1.Name = "LBLAvailableDrugs1";
            this.LBLAvailableDrugs1.Size = new System.Drawing.Size(44, 19);
            this.LBLAvailableDrugs1.TabIndex = 4;
            this.LBLAvailableDrugs1.Text = "Sum";
            // 
            // LBLAvailableDrugs2
            // 
            this.LBLAvailableDrugs2.AutoSize = true;
            this.LBLAvailableDrugs2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAvailableDrugs2.ForeColor = System.Drawing.Color.White;
            this.LBLAvailableDrugs2.Location = new System.Drawing.Point(213, 32);
            this.LBLAvailableDrugs2.Name = "LBLAvailableDrugs2";
            this.LBLAvailableDrugs2.Size = new System.Drawing.Size(44, 19);
            this.LBLAvailableDrugs2.TabIndex = 4;
            this.LBLAvailableDrugs2.Text = "Sum";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = global::Pharmacy_Management_System.Properties.Resources.icons8_check_mark;
            this.guna2PictureBox3.Location = new System.Drawing.Point(21, 19);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(42, 43);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 0;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 6;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.DarkSlateGray;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::Pharmacy_Management_System.Properties.Resources.icons8_add_48;
            this.guna2Button1.Location = new System.Drawing.Point(722, 106);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(187, 45);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Add New Drug";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDrugInfoToolStripMenuItem,
            this.toolStripSeparator1,
            this.editDrugToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 54);
            // 
            // showDrugInfoToolStripMenuItem
            // 
            this.showDrugInfoToolStripMenuItem.Name = "showDrugInfoToolStripMenuItem";
            this.showDrugInfoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.showDrugInfoToolStripMenuItem.Text = "Show Drug Info";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // editDrugToolStripMenuItem
            // 
            this.editDrugToolStripMenuItem.Name = "editDrugToolStripMenuItem";
            this.editDrugToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.editDrugToolStripMenuItem.Text = "Edit Drug";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Gainsboro;
            this.linkLabel2.Location = new System.Drawing.Point(243, 63);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(39, 13);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Details";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkColor = System.Drawing.Color.Gainsboro;
            this.linkLabel3.Location = new System.Drawing.Point(241, 63);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(39, 13);
            this.linkLabel3.TabIndex = 5;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Details";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DrugName";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DrugForm";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Drug picture";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // FrmManageDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(921, 573);
            this.Controls.Add(this.DGVDrugs);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmManageDrugs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmManageDrugs";
            this.Load += new System.EventHandler(this.FrmManageDrugs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDrugs)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DataGridView DGVDrugs;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label LBLExpiredDrugs2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBLExpiredDrugs1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLSumDrugs1;
        private System.Windows.Forms.Label LBLSumDrugs2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LBLAvailableDrugs1;
        private System.Windows.Forms.Label LBLAvailableDrugs2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDrugInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editDrugToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
    }
}
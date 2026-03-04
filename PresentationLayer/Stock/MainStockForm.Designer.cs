namespace Pharmacy_Management_System.Stock
{
    partial class MainStockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainStockForm));
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.LBLRows = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBSelect = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TBSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.DGVDrugs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDrugs)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderColor = System.Drawing.Color.White;
            this.guna2Panel3.BorderRadius = 15;
            this.guna2Panel3.BorderThickness = 5;
            this.guna2Panel3.Controls.Add(this.LBLRows);
            this.guna2Panel3.Controls.Add(this.label4);
            this.guna2Panel3.Controls.Add(this.CBSelect);
            this.guna2Panel3.Controls.Add(this.TBSearch);
            this.guna2Panel3.Controls.Add(this.DGVDrugs);
            this.guna2Panel3.Controls.Add(this.guna2Button1);
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2Panel3.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel3.Location = new System.Drawing.Point(1, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Depth = 5;
            this.guna2Panel3.ShadowDecoration.Enabled = true;
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(1232, 608);
            this.guna2Panel3.TabIndex = 8;
            // 
            // LBLRows
            // 
            this.LBLRows.AutoSize = true;
            this.LBLRows.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRows.Location = new System.Drawing.Point(69, 584);
            this.LBLRows.Name = "LBLRows";
            this.LBLRows.Size = new System.Drawing.Size(15, 17);
            this.LBLRows.TabIndex = 14;
            this.LBLRows.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 583);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Rows : ";
            // 
            // CBSelect
            // 
            this.CBSelect.BackColor = System.Drawing.Color.Transparent;
            this.CBSelect.BorderRadius = 5;
            this.CBSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSelect.FocusedColor = System.Drawing.Color.Empty;
            this.CBSelect.FocusedState.Parent = this.CBSelect;
            this.CBSelect.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBSelect.FormattingEnabled = true;
            this.CBSelect.HoverState.Parent = this.CBSelect;
            this.CBSelect.ItemHeight = 30;
            this.CBSelect.Items.AddRange(new object[] {
            "None",
            "DrugName",
            "ExpirationDate"});
            this.CBSelect.ItemsAppearance.Parent = this.CBSelect;
            this.CBSelect.Location = new System.Drawing.Point(386, 62);
            this.CBSelect.Name = "CBSelect";
            this.CBSelect.ShadowDecoration.Parent = this.CBSelect;
            this.CBSelect.Size = new System.Drawing.Size(192, 36);
            this.CBSelect.TabIndex = 13;
            // 
            // TBSearch
            // 
            this.TBSearch.BorderRadius = 5;
            this.TBSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBSearch.DefaultText = "";
            this.TBSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBSearch.DisabledState.Parent = this.TBSearch;
            this.TBSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBSearch.FocusedState.Parent = this.TBSearch;
            this.TBSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBSearch.HoverState.Parent = this.TBSearch;
            this.TBSearch.Location = new System.Drawing.Point(80, 62);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.PasswordChar = '\0';
            this.TBSearch.PlaceholderText = "";
            this.TBSearch.SelectedText = "";
            this.TBSearch.ShadowDecoration.Parent = this.TBSearch;
            this.TBSearch.Size = new System.Drawing.Size(200, 36);
            this.TBSearch.TabIndex = 12;
            this.TBSearch.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
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
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
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
            this.DGVDrugs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVDrugs.Location = new System.Drawing.Point(21, 104);
            this.DGVDrugs.Name = "DGVDrugs";
            this.DGVDrugs.ReadOnly = true;
            this.DGVDrugs.RowHeadersVisible = false;
            this.DGVDrugs.RowHeadersWidth = 30;
            this.DGVDrugs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDrugs.Size = new System.Drawing.Size(1200, 476);
            this.DGVDrugs.TabIndex = 11;
            this.DGVDrugs.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DGVDrugs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVDrugs.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVDrugs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVDrugs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVDrugs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVDrugs.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.DGVDrugs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            // Column1
            // 
            this.Column1.HeaderText = "BatchID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DrugName";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PurchasePricePerUnit";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "SellingPricePerUnit";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ExpirationDate";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "DrugPic";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 6;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::Pharmacy_Management_System.Properties.Resources.icons8_add_48;
            this.guna2Button1.Location = new System.Drawing.Point(1026, 53);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(195, 45);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Add Stock";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search By :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Manage Stock";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createReportToolStripMenuItem,
            this.toolStripSeparator1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 32);
            // 
            // createReportToolStripMenuItem
            // 
            this.createReportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createReportToolStripMenuItem.Image")));
            this.createReportToolStripMenuItem.Name = "createReportToolStripMenuItem";
            this.createReportToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.createReportToolStripMenuItem.Text = "Create Report";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // MainStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1234, 620);
            this.Controls.Add(this.guna2Panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainStockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Manager";
            this.Load += new System.EventHandler(this.MainStockForm_Load);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDrugs)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView DGVDrugs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private Guna.UI2.WinForms.Guna2TextBox TBSearch;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox CBSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
        private System.Windows.Forms.Label LBLRows;
        private System.Windows.Forms.Label label4;
    }
}
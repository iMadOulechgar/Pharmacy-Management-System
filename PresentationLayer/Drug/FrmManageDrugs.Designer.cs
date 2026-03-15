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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDrugInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editDrugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.CBSelect = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TBSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVDrugs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDrugs)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 6;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::Pharmacy_Management_System.Properties.Resources.icons8_add_48;
            this.guna2Button1.Location = new System.Drawing.Point(722, 67);
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
            this.showDrugInfoToolStripMenuItem.Image = global::Pharmacy_Management_System.Properties.Resources.icons8_show_property_100;
            this.showDrugInfoToolStripMenuItem.Name = "showDrugInfoToolStripMenuItem";
            this.showDrugInfoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.showDrugInfoToolStripMenuItem.Text = "Show Drug Info";
            this.showDrugInfoToolStripMenuItem.Click += new System.EventHandler(this.showDrugInfoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // editDrugToolStripMenuItem
            // 
            this.editDrugToolStripMenuItem.Image = global::Pharmacy_Management_System.Properties.Resources.icons8_edit_100;
            this.editDrugToolStripMenuItem.Name = "editDrugToolStripMenuItem";
            this.editDrugToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.editDrugToolStripMenuItem.Text = "Edit Drug";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Manage Drugs";
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
            "DrugName"});
            this.CBSelect.ItemsAppearance.Parent = this.CBSelect;
            this.CBSelect.Location = new System.Drawing.Point(372, 76);
            this.CBSelect.Name = "CBSelect";
            this.CBSelect.ShadowDecoration.Parent = this.CBSelect;
            this.CBSelect.Size = new System.Drawing.Size(192, 36);
            this.CBSelect.TabIndex = 17;
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
            this.TBSearch.Location = new System.Drawing.Point(76, 76);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.PasswordChar = '\0';
            this.TBSearch.PlaceholderText = "";
            this.TBSearch.SelectedText = "";
            this.TBSearch.ShadowDecoration.Parent = this.TBSearch;
            this.TBSearch.Size = new System.Drawing.Size(200, 36);
            this.TBSearch.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(291, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Search By :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(14, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Search :";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Drug picture";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DrugForm";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DrugName";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            this.DGVDrugs.ColumnHeadersHeight = 50;
            this.DGVDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVDrugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DGVDrugs.ContextMenuStrip = this.contextMenuStrip1;
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
            this.DGVDrugs.Location = new System.Drawing.Point(12, 118);
            this.DGVDrugs.Name = "DGVDrugs";
            this.DGVDrugs.ReadOnly = true;
            this.DGVDrugs.RowHeadersVisible = false;
            this.DGVDrugs.RowHeadersWidth = 40;
            this.DGVDrugs.RowTemplate.Height = 100;
            this.DGVDrugs.RowTemplate.ReadOnly = true;
            this.DGVDrugs.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDrugs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDrugs.Size = new System.Drawing.Size(897, 443);
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
            this.DGVDrugs.ThemeStyle.HeaderStyle.Height = 50;
            this.DGVDrugs.ThemeStyle.ReadOnly = true;
            this.DGVDrugs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVDrugs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVDrugs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVDrugs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVDrugs.ThemeStyle.RowsStyle.Height = 100;
            this.DGVDrugs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVDrugs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // FrmManageDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(921, 573);
            this.Controls.Add(this.CBSelect);
            this.Controls.Add(this.TBSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGVDrugs);
            this.Controls.Add(this.guna2Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmManageDrugs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmManageDrugs";
            this.Load += new System.EventHandler(this.FrmManageDrugs_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDrugs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDrugInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editDrugToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox CBSelect;
        private Guna.UI2.WinForms.Guna2TextBox TBSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private Guna.UI2.WinForms.Guna2DataGridView DGVDrugs;
    }
}
using BusinessLayer;
using DevComponents.DotNetBar.Controls;
using Pharmacy_Management_System.Validation_AllSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Pharmacy_Management_System.Drug
{
    public partial class FrmManageDrugs : Form
    {
        public FrmManageDrugs()
        {
            InitializeComponent();
        }

        private void LoadData()
        {   
            DGVDrugs.Rows.Clear();

            DataTable Drugs = clsBusinessDrugs.GetDrugs();
            DGVDrugs.RowTemplate.Height = 50;

            foreach (DataRow row in Drugs.Rows)
            {
                Image Local = Image.FromFile((string)row["PicturePath"]);
                DGVDrugs.Rows.Add((string)row["DrugName"], (string)row["DrugForm"], (bool)row["IsActive"], Local);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddOrEditDrug Add = new AddOrEditDrug();
            Add.LoadDataIn += LoadData;
            Add.ShowDialog();
        }

        private void FrmManageDrugs_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void showDrugInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowDrugInfo DrugInfo = new FrmShowDrugInfo(DGVDrugs.CurrentRow.Cells[0].Value.ToString());
            DrugInfo.ShowDialog();
        }
    }
}

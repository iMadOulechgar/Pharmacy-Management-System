using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using ImadDraw = System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Image;
using Pharmacy_Management_System.Login;
using Pharmacy_Management_System.Reports;

namespace Pharmacy_Management_System.Stock
{
    public partial class MainStockForm : Form
    {
        public MainStockForm()
        {
            InitializeComponent();
        }

        private DataTable Stock;

        private void LoadDataInDGVLoadDataInDGV()
        {
            DGVDrugs.Rows.Clear();

            CBSelect.SelectedIndex = 0;

            Stock = clsBusinessBatches.GetAllBatches();

            foreach (DataRow Row in Stock.Rows)
            {
                ImadDraw.Image Pic = ImadDraw.Image.FromFile((string)Row["PicturePath"]);
                DGVDrugs.Rows.Add((int)Row["BatchID"], (string)Row["DrugName"], (int)Row["Quantity"], (decimal)Row["PurchasePricePerUnit"],
                    (decimal)Row["SellingPricePerUnit"] , ((DateTime)Row["ExpirationDate"]).Date.ToString(), Pic);
            }

            LBLRows.Text = DGVDrugs.RowCount.ToString();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string ColumnName = CBSelect.Text;
            string TextLign = TBSearch.Text;
            int Index = 0;

            if (ColumnName == "None")
            {
                TBSearch.Text = "";
                TextLign = "";
                return;
            }
            else
            {
                switch (ColumnName)
                {
                    case "DrugName":
                        Index = 1;
                    break;

                    case "Quantity":
                        Index = 2;
                    break;

                }


                foreach (DataGridViewRow Row in DGVDrugs.Rows)
                {
                    if (Row.Cells[Index].Value.ToString().Contains(TextLign))
                        Row.Visible = true;
                    else
                        Row.Visible = false;    
                }
            }
        }

        private void MainStockForm_Load(object sender, EventArgs e)
        {
            LoadDataInDGVLoadDataInDGV();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddBatches Batches = new AddBatches();
            Batches.LoadDataAfterAdd += LoadDataInDGVLoadDataInDGV;
            Batches.ShowDialog();
        }

        private void createReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsReportInfo.CreateReport("ReportN°"+(int)DGVDrugs.CurrentRow.Cells[0].Value+".Pdf", DGVDrugs.CurrentRow.Cells[1].Value.ToString());
        }




    }
}

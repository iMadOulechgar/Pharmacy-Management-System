using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            CBSelect.SelectedIndex = 0;

            Stock = clsBusinessBatches.GetAllBatches();

            foreach (DataRow Row in Stock.Rows)
            {
                Image Pic = Image.FromFile((string)Row["PicturePath"]);
                DGVDrugs.Rows.Add((int)Row["BatchID"], (string)Row["DrugName"], (int)Row["Quantity"], (decimal)Row["PerchasePricePerUnit"],
                    (decimal)Row["SellingPricePerUnit"] , (DateTime)Row["ExpirationDate"] , Pic);
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

            if (ColumnName == "None")
            {
                MessageBox.Show("Select A Column In ComboBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBSearch.Text = "";
                return;
            }
            else
            {
                if (ColumnName == "DrugName")
                {
                    Stock.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", ColumnName, TextLign); 
                }
                else
                {
                    Stock.DefaultView.RowFilter = string.Format("[{0}] = '{1}'", ColumnName, TextLign);
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
            Batches.ShowDialog();
        }
    }
}

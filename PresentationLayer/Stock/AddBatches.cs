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
    public partial class AddBatches : Form
    {
        public AddBatches()
        {
            InitializeComponent();
            _DrugBatches = new clsBusinessBatches();
        }

        private clsBusinessBatches _DrugBatches;

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillObjectWithData()
        {
            _DrugBatches.DrugID = clsBusinessDrugs.GetDrugIDByName(CBDrugsName.Text);
            _DrugBatches.Quantity = (int)NUDQuantity.Value;
            _DrugBatches.PerchasePrice = Convert.ToDecimal(TBPurchasePrice.Text);
            _DrugBatches.SellingPrice = Convert.ToDecimal(TBSellingPrice.Text);
            _DrugBatches.ExpirationDate = DTExpirationDate.Value;
        }

        private bool Validation()
        {
            if (Convert.ToDecimal(TBPurchasePrice.Text) < Convert.ToDecimal(TBSellingPrice.Text))
            {
                MessageBox.Show("The Selling Price Could Not Greater Then Purchase Price","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            if (DTExpirationDate.Value < DateTime.Now.AddYears(1))
            {
                MessageBox.Show("The Expiration Date Could Not Be Less Then One Year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }





        }


        private void BTNSave_Click(object sender, EventArgs e)
        {

        }
    }
}

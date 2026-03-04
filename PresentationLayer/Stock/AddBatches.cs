using BusinessLayer;
using Pharmacy_Management_System.Stock.Controles;
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

namespace Pharmacy_Management_System.Stock
{
    public partial class AddBatches : Form
    {
        public AddBatches()
        {
            InitializeComponent();
            _DrugBatches = new clsBusinessBatches();
        }

        public event Action LoadDataAfterAdd;

        private clsBusinessBatches _DrugBatches;

        private void FillComboBox()
        {
            CBDrugsName.SelectedIndex = 0;

            DataTable Table = clsBusinessDrugs.GetDrugs();

            foreach (DataRow Row in Table.Rows)
            {
                CBDrugsName.Items.Add(Row["DrugName"].ToString());
            }
        }

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
            _DrugBatches.ExpirationDate = DTExpirationDate.Value.Date;
            _DrugBatches.CreatedAt = DateTime.Now;  
        }

        private void _SetControlsInPanel()
        {
            DataTable Table = clsBusinessStockHistory.GetAllStock();

            foreach (DataRow item in Table.Rows)
            {
                StockHistoryctrl StockHistory = new StockHistoryctrl((DateTime)item["CreatedAt"], (string)item["ActionType"],
                    (int)item["Quantity"],clsBusinessUsers.GetUserNameByID((int)item["CreatedByUserID"]));  
                FlowPanel.Controls.Add(StockHistory);
            }
        }

        private bool Validation()
        {
            if (Convert.ToDouble(TBSellingPrice.Text) < Convert.ToDouble(TBPurchasePrice.Text))
            {
                MessageBox.Show("The Selling Price Could Not Greater Then Purchase Price","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            if (DTExpirationDate.Value < DateTime.Now.AddYears(1))
            {
                MessageBox.Show("The Expiration Date Could Not Be Less Then One Year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!(clsValidation.CheckStringIsNumber(TBSellingPrice.Text) && clsValidation.CheckStringIsNumber(TBPurchasePrice.Text)) && (Convert.ToDouble(TBSellingPrice.Text) < 0 || Convert.ToDouble(TBPurchasePrice.Text) < 0))
            {
                MessageBox.Show("Make Sure The Input Prices Are Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void _RestDataFromForm()
        {
            CBDrugsName.SelectedIndex = 0;
            NUDQuantity.Value = 0;
            TBPurchasePrice.Text = "";
            TBSellingPrice.Text = "";
            DTExpirationDate.Value = DateTime.Now;
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                FillObjectWithData();

                if (_DrugBatches.Save())
                {
                    MessageBox.Show("The Batch Has Been Added Successfly","Confirm",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    if (MessageBox.Show("Do You Wanna Add Another Batche","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _RestDataFromForm();
                        _SetControlsInPanel();
                    }
                    else
                    {
                        LoadDataAfterAdd?.Invoke();
                        this.Close();
                    }
                }
            }
        }

        private void TBPurchasePrice_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidation.CheckStringIsNumber(TBPurchasePrice.Text))
            {
                errorProvider1.SetError(TBPurchasePrice,"Error , Text Inacceptable");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void TBSellingPrice_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidation.CheckStringIsNumber(TBSellingPrice.Text))
            {
                errorProvider1.SetError(TBSellingPrice, "Error , Text InAcceptable");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void AddBatches_Load(object sender, EventArgs e)
        {
            FillComboBox();
            _SetControlsInPanel();
        }
    }
}

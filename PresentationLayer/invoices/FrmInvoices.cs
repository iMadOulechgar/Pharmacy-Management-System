using BusinessLayer;
using Pharmacy_Management_System.History.Controles;
using Pharmacy_Management_System.invoices.Controles;
using Pharmacy_Management_System.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.Drug
{
    public partial class FrmInvoices : Form
    {
        public FrmInvoices()
        {
            InitializeComponent();
        }

        private clsBusinessInvoiceDetails _InvoiceDetails = new clsBusinessInvoiceDetails();

        public event Action<int> DeleteFromBasket;
        public event Action Rest;

        private void DeleteBasket(int DrugID)
        {
            DeleteFromBasket?.Invoke(DrugID);
        }
        
        public void SetControlesInPanel(CtLinvoiceDetails Det)
        {
            LayoutPanelInVoices.Controls.Add(Det);
        }

        private bool SaveInvoice()
        {
            _InvoiceDetails.TableDetails.Columns.Add("InvoiceID", typeof(int)).SetOrdinal(0);
            _InvoiceDetails.TableDetails.Columns.Add("Quantity",typeof(int)).SetOrdinal(1);
            _InvoiceDetails.TableDetails.Columns.Add("Price", typeof(decimal)).SetOrdinal(2);
            _InvoiceDetails.TableDetails.Columns.Add("DrugID", typeof(int)).SetOrdinal(3);
            _InvoiceDetails.TableDetails.Columns.Add("BatchID", typeof(int)).SetOrdinal(4);

            decimal Price  = 0;
            int TotalDrugs = 0;

            foreach (CtLinvoiceDetails item in LayoutPanelInVoices.Controls.OfType<CtLinvoiceDetails>())
            {
                foreach (var Card in item.Cards)
                {
                    Price += Card.Item2;
                    TotalDrugs += Card.Item1;
                    _InvoiceDetails.TableDetails.Rows.Add(null,Card.Item1,Card.Item2,Card.Item3,Card.Item4);
                }
                item._RestDataTooDefault();
            }

            _InvoiceDetails.PharmacistID = clsCurrentUserLogin.CurrentUser.UserID;
            _InvoiceDetails.Price = Price;
            _InvoiceDetails.invoiceNumber = TotalDrugs;
            _InvoiceDetails.CreatedAt = DateTime.Now;

            if (_InvoiceDetails.Save())
            {
                LayoutPanelInVoices.Controls.Clear();
                Rest?.Invoke();

                return true;
            }

            return false;
        }

        private void FrmInvoices_Load(object sender, EventArgs e)
        {
            CtLinvoiceDetails.Delete += DeleteBasket;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            if (LayoutPanelInVoices.Controls.Count == 0)
            {
                MessageBox.Show("There Is No Cards Too InVoice","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (SaveInvoice())
                {
                    MessageBox.Show("Data Saved Succesfly","Confirm",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



    }
}

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
            _InvoiceDetails = new clsBusinessInvoiceDetails();
        }

        private clsBusinessInvoiceDetails _InvoiceDetails;
        public Tuple<int, int, decimal, DateTime> TupleHoldingData;
        public event Action<string> DeleteFromBasket;

        private void DeleteBasket(string Drugname)
        {
            DeleteFromBasket?.Invoke(Drugname);
        }
        
        public void SetControlesInPanel(CtLinvoiceDetails Det)
        {
            LayoutPanelInVoices.Controls.Add(Det);
        }

        private void FrmInvoices_Load(object sender, EventArgs e)
        {
            CtLinvoiceDetails.Delete += DeleteBasket;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void FillDataIntoInvoiceDetailsTable(DataTable Table , int invoiceNum , decimal Price)
        {
            _InvoiceDetails.TableDetails = Table;
            _InvoiceDetails.invoiceNumber = invoiceNum;
            _InvoiceDetails.PharmacistID = clsCurrentUserLogin.CurrentUser.UserID;
            _InvoiceDetails.Price = Price;
            _InvoiceDetails.CreatedAt = DateTime.Now;
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            int InvoiceNum = 0;
            decimal PriceTotal = 0;
            DataTable Table = new DataTable();
            Table.Columns.Add("invoiceID",typeof(int));
            Table.Columns.Add("Quantity", typeof(int));
            Table.Columns.Add("Price", typeof(decimal));
            Table.Columns.Add("DrugID", typeof(int));
            Table.Columns.Add("BatchID", typeof(int));

            foreach (CtLinvoiceDetails CtlInvoice in LayoutPanelInVoices.Controls.OfType<CtLinvoiceDetails>())
            {
                if (CtlInvoice.BatchID.Count == 1)
                {
                    PriceTotal += CtlInvoice.Price;
                    InvoiceNum++;
                    Table.Rows.Add(null, CtlInvoice.Quantity, CtlInvoice.Price, CtlInvoice.DrugID, CtlInvoice.BatchID[0]);
                }
                else
                {
                    for (int i = 0; i < CtlInvoice.BatchID.Count; i++)
                    {
                        InvoiceNum++;
                        Table.Rows.Add(null, CtlInvoice.Quantity, CtlInvoice.Price, CtlInvoice.DrugID, CtlInvoice.BatchID[i]);
                    }
                    PriceTotal += CtlInvoice.Price;
                }
            }
            
            FillDataIntoInvoiceDetailsTable(Table, InvoiceNum,PriceTotal);

            if (_InvoiceDetails.Save())
                MessageBox.Show("Data Saved Successfly");
            else
                MessageBox.Show("Invalid Data");
            

        }



    }
}

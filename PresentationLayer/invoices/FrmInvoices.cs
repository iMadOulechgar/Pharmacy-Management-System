using BusinessLayer;
using Pharmacy_Management_System.invoices.Controles;
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

        void FillDataIntoInvoiceDetailsTable(DataTable Table)
        {
            _InvoiceDetails.TableDetails = Table;
            _InvoiceDetails.invoiceNumber = TupleHoldingData.Item1;
            _InvoiceDetails.PharmacistID = TupleHoldingData.Item2;
            _InvoiceDetails.Price = TupleHoldingData.Item3;
            _InvoiceDetails.CreatedAt = TupleHoldingData.Item4;
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {

            DataTable Table = new DataTable();
            Table.Columns.Add("invoiceID",typeof(int));
            Table.Columns.Add("Quantity", typeof(int));
            Table.Columns.Add("Price", typeof(decimal));
            Table.Columns.Add("DrugID", typeof(int));


            foreach (CtLinvoiceDetails CtlInvoice in LayoutPanelInVoices.Controls.OfType<CtLinvoiceDetails>())
            {
                Table.Rows.Add(null,CtlInvoice.Quantity, CtlInvoice.Price, CtlInvoice.DrugID);
            }
            
            FillDataIntoInvoiceDetailsTable(Table);

            if (_InvoiceDetails.Save())
                MessageBox.Show("Data Saved Successfly");
            else
                MessageBox.Show("Invalid Data");
            

        }



    }
}

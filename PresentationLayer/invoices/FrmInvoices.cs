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
        public event Action<int> DeleteFromBasket;

        private void DeleteBasket(int DrugID)
        {
            DeleteFromBasket?.Invoke(DrugID);
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

        private void BTNSave_Click(object sender, EventArgs e)
        {




        }



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.invoices.Controles
{
    public partial class CtLinvoiceDetails : UserControl
    {
        public CtLinvoiceDetails()
        {
            InitializeComponent();
        }

        public void SetDataIntoControl(string Path , string Drugname , decimal Price , string FormName , string Username)
        {
            PBPath.Load(Path);
            LBLDrugname.Text = Drugname;
            LBLDrugForm.Text = FormName;
            LBLPricePerUnit.Text = Convert.ToDecimal(Price).ToString();
            LBLUsername.Text = Username;    
        }

        private void CtLinvoiceDetails_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }
    }
}

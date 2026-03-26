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

        public static event Action<string> Delete;

        public void SetDataIntoControl(string Path , string Drugname , decimal Price , string FormName , int Quantity,string Username)
        {
            PBPath.Load(Path);
            LBLDrugname.Text = Drugname;
            LBLDrugForm.Text = FormName;
            LBLPricePerUnit.Text = Convert.ToDecimal(Price).ToString();
            LBLUsername.Text = Username;
            LBLQuantity.Text = Quantity.ToString();
        }
        
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Delete?.Invoke(LBLDrugname.Text);
            this.Dispose();
        }
    }
}

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

namespace Pharmacy_Management_System.invoices.Controles
{
    public partial class CtLinvoiceDetails : UserControl
    {
        public CtLinvoiceDetails()
        {
            InitializeComponent();
        }

        public static event Action<int,decimal> AfterDeleteItem;
        public static event Action<string> Delete;

        public List<int> BatchID ;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int DrugID { get; set; }


        public void SetDataIntoControl(string Path , string Drugname , decimal Price , string FormName , int Quantity,string Username,List<int>SendBatchID)
        {   
            this.BatchID = new List<int>(SendBatchID);
            PBPath.Load(Path);
            LBLDrugname.Text = Drugname;
            LBLDrugForm.Text = FormName;
            LBLPricePerUnit.Text = Convert.ToDecimal(Price).ToString();
            LBLUsername.Text = Username;
            LBLQuantity.Text = Quantity.ToString();

            this.DrugID = clsBusinessDrugs.GetDrugIDByName(Drugname);
            this.Quantity = Quantity;
            this.Price = Price;
        }
        
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AfterDeleteItem?.Invoke(int.Parse(LBLQuantity.Text),Convert.ToDecimal(LBLPricePerUnit.Text));
            Delete?.Invoke(LBLDrugname.Text);
            this.Dispose();
        }
    }
}

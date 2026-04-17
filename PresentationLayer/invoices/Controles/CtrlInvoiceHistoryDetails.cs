using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.History.Controles
{
    public partial class CtrlInvoiceHistoryDetails : UserControl
    {
        public CtrlInvoiceHistoryDetails()
        {
            InitializeComponent();
        }

        public CtrlInvoiceHistoryDetails(string Username, string NumInvoices, string PicPath, DateTime DT, decimal Amount)
        {
            InitializeComponent();

            this.username = Username;
            this.NumberOfProducts = NumInvoices;
            this.PicturePath = PicPath;
            this.DateAndTime = DT;
            this.Amount = Amount;

            SetDataInControle();
        }


        private string username { get; set; }
        private string NumberOfProducts { get; set; }
        private string PicturePath { get; set; }
        private DateTime DateAndTime { get; set; }
        private decimal Amount { get; set; }



        public void SetDataInControle()
        {
            LBLTime.Text = DateAndTime.ToString();
            LBLUsername.Text = username;
            UserPic.Load(PicturePath);
            LBLDesc.Text = LBLUsername.Text + " " + "Selled : "+ NumberOfProducts + " Of Drugs , Amount : "+ Amount;
        }

    }
}

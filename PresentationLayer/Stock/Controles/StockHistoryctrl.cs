using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.Stock.Controles
{
    public partial class StockHistoryctrl : UserControl
    {
        public StockHistoryctrl(DateTime date, string action, int quantity, string userAction,string DrugName)
        {
            InitializeComponent();
            Date = date;
            Action = action;
            Quantity = quantity;
            UserAction = userAction;
            this.DrugName = DrugName;

            History();
        }

        public DateTime Date { get; set; }
        public string Action { get; set; }
        public int Quantity {  get; set; }
        public string UserAction { get; set; }
        public string DrugName {  get; set; }

        private void History()
        {
            LBLDate.Text = this.Date.Date.ToString();
            LBLAction.Text = this.Action;
            LBLQuatity.Text = this.Quantity.ToString(); 
            LBLUserAction.Text = this.UserAction;
            LBLDrugName.Text = this.DrugName;
        }

        private void LBLUserAction_Click(object sender, EventArgs e)
        {

        }
    }
}

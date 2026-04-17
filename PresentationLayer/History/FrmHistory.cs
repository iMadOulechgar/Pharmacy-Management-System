using BusinessLayer;
using Pharmacy_Management_System.History.Controles;
using Pharmacy_Management_System.Stock.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.History
{
    public partial class FrmHistory : Form
    {
        public FrmHistory()
        {
            InitializeComponent();

        }

        private DataTable StockHistory;
        private DataTable UsersHistory;
        private CtrlInvoiceHistoryDetails TempInvoiceHistory;
        private StockHistoryctrl TempStockHistory;

        private void _LoadStockHistoryDataInPanel()
        {
            UsersHistory = clsBusinessInvoices.GetAllDataHistoryOfInvoices();

            foreach (DataRow row in UsersHistory.Rows)
            {
                TempInvoiceHistory = new CtrlInvoiceHistoryDetails(row["Username"].ToString(), row["InvoiceNumber"].ToString(),
                    row["ImagePath"].ToString(), (DateTime)row["CreatedAt"], (decimal)row["TotalAmount"]);
                LayoutUsers.Controls.Add(TempInvoiceHistory);
            }
        }

        private void _SetControlsInPanel()
        {
            StockHistory = clsBusinessStockHistory.GetAllStock();

            foreach (DataRow item in StockHistory.Rows)
            {
                TempStockHistory = new StockHistoryctrl((DateTime)item["CreatedAt"], (string)item["ActionType"],
                    (int)item["NewQuantity"], clsBusinessUsers.GetUserNameByID((int)item["CreatedByUserID"]), (string)item["DrugName"]);
                LayoutHistory.Controls.Add(TempStockHistory);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmHistory_Load(object sender, EventArgs e)
        {
            _LoadStockHistoryDataInPanel();
            _SetControlsInPanel();
        }
    }
}

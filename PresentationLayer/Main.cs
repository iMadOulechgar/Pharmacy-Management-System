using BusinessLayer;
using Guna.UI2.WinForms.Suite;
using Pharmacy_Management_System.Drug;
using Pharmacy_Management_System.invoices.Controles;
using Pharmacy_Management_System.Login;
using Pharmacy_Management_System.Notification.Controles;
using Pharmacy_Management_System.Stock;
using Pharmacy_Management_System.Users;
using Pharmacy_Management_System.Validation_AllSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private int PanelCounter = 0;
        private List<Tuple<string, string, decimal, string, int,string,List<int>>> TempPanel = new List<Tuple<string, string, decimal, string, int,string, List<int>>>();


        private void DeleteFromBasket(string DrugName)
        {
            var item = TempPanel.Find(x => x.Item2 == DrugName);

            if (item != null)
            {
                if (item.Item5 > 1)
                    PanelCounter -= item.Item5;
                else
                    PanelCounter -= 1;

                LBLPanel.Text = PanelCounter.ToString();
                TempPanel.Remove(item);
            }
        }

        private void LoadData()
        {
            DataTable Drugs = clsBusinessDrugs.GetAllDrugsForSale();
            DGVDrugs.RowTemplate.Height = 50;

            foreach (DataRow row in Drugs.Rows)
            {
                Image Local = Image.FromFile((string)row["PicturePath"]);
                DGVDrugs.Rows.Add((int)row["DrugID"],(string)row["DrugName"], (string)row["DrugForm"], (bool)row["IsActive"], Local);
            }
        }

        public void ChangeUiPictureBoxForCurrentUser(string Path)
        {
            ProfilePicture.Load(Path);
        }

        private void _FillUserDataInLoad()
        {
            LoadData();
            LBLUser.Text = clsCurrentUserLogin.CurrentUser.Username;
            LBLRole.Text = clsCurrentUserLogin.CurrentUser.CompositionRoles.RoleName;
            ProfilePicture.Load(clsCurrentUserLogin.CurrentUser.ImagePath);
            LBLDate.Text = DateTime.Now.ToShortDateString();
            LBLTime.Text = DateTime.Now.ToShortTimeString();
            LayoutPanelNotification.Visible = false;
            NotificationPic.Visible = false;
            LBLTotlaDrugs1.Text = clsBusinessDrugs.TotalDrugs().ToString();
            LBLTotlaDrugs2.Text = LBLTotlaDrugs1.Text;
            LBLAvailableStock1.Text = clsBusinessDrugs.GetAllAvailableDrugs().ToString();
            LBLAvailableStock2.Text = LBLAvailableStock1.Text;
            LBLTotalSales1.Text = clsBusinessInvoices.GetTotalSales().ToString();
            LBLTotalSales2.Text = LBLTotalSales1.Text;
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            _FillUserDataInLoad();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            MainStockForm frm = new MainStockForm();
            frm.ShowDialog();
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            frmManageUsers Users = new frmManageUsers();
            Users.StoreMethodChangePicture(ChangeUiPictureBoxForCurrentUser);
            Users.ShowDialog();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            FrmManageDrugs frm = new FrmManageDrugs();
            frm.ShowDialog();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            FrmInvoices Invoices = new FrmInvoices();
            Invoices.DeleteFromBasket += DeleteFromBasket;

            CtLinvoiceDetails Details;

            foreach (var item in TempPanel)
            {
                Details = new CtLinvoiceDetails();
                Details.SetDataIntoControl(item.Item1,item.Item2,item.Item3,item.Item4,item.Item5,item.Item6,item.Item7);
                Invoices.SetControlesInPanel(Details);         
            }

            Invoices.TupleHoldingData = new Tuple<int, int, decimal, DateTime>(TempPanel.Sum(x => x.Item5), clsCurrentUserLogin.CurrentUser.UserID, TempPanel.Sum(x => x.Item3), DateTime.Now);
            Invoices.ShowDialog();
        }

        private void addDrugInThePanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            PanelCounter = 0;
            LBLPanel.Text = "0";
            TempPanel.Clear();
        }

        private void showDrugInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowDrugInfo DrugInfo = new FrmShowDrugInfo((int)DGVDrugs.CurrentRow.Cells[0].Value);
            DrugInfo.Show();
        }

        private void TBSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

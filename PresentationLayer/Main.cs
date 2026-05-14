using BusinessLayer;
using Guna.UI2.WinForms.Suite;
using iText.StyledXmlParser.Jsoup.Safety;
using Pharmacy_Management_System.Drug;
using Pharmacy_Management_System.History;
using Pharmacy_Management_System.invoices.Controles;
using Pharmacy_Management_System.Login;
using Pharmacy_Management_System.Notification.Controles;
using Pharmacy_Management_System.Properties;
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
        private List<CtLinvoiceDetails> TempPanel = new List<CtLinvoiceDetails>();

        private void ResTheCounter()
        {
            PanelCounter = 0;
            LBLPanel.Text = PanelCounter.ToString();
        }

        private void DeleteFromBasket(int DrugID)
        {
            TempPanel.RemoveAll(Back => Back.DrugID == DrugID);
            PanelCounter--;
            LBLPanel.Text = PanelCounter.ToString();
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

        private void Permissions()
        {
            string PermissionAllowed = clsBusinessRoles.GetRoleNameByID(clsCurrentUserLogin.CurrentUser.RoleID);

            switch (PermissionAllowed)
            {
                case "Pharmacist":

                    TabUsers.Enabled = false;
                    TabUsers.FillColor = Color.LightGray;
                    PBUsers.Image = Resources.icons8_lock_100;
                    TabStock.Enabled = false;
                    TabStock.FillColor = Color.LightGray;
                    PBStock.Image = Resources.icons8_lock_100;
                    TabHistory.Enabled = false;
                    TabHistory.FillColor = Color.LightGray;
                    PBHistory.Image = Resources.icons8_lock_100;
                    break;

                case "StockManager":
                    TabUsers.Enabled = false;
                    TabUsers.FillColor = Color.LightGray;
                    PBUsers.Image = Resources.icons8_lock_100;
                    TabHistory.Enabled = false;
                    TabHistory.FillColor = Color.LightGray;
                    PBHistory.Image = Resources.icons8_lock_100;
                    break;
            }
        }

        public void ChangeUiPictureBoxForCurrentUser(string Path)
        {
            ProfilePicture.Load(Path);
        }

        public void ReLoadNotificationInfo()
        {
            ctlNotification Notification;
            DataTable Temp = clsBusinessBatches.GetAllBatches();
            DataRow[] Row = Temp.AsEnumerable().Where(R => (int)R["Quantity"] <= 10).ToArray();

            if (Row.Length > 0)
            {
                foreach (DataRow Rw in Row)
                {
                    Notification = new ctlNotification();

                }


            }




        }

        private void _FillUserDataInLoad()
        {
            LoadData();
            Permissions();
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
            Invoices.Rest += ResTheCounter;

            foreach (var item in TempPanel)
            {
                Invoices.SetControlesInPanel(item);
            }

            Invoices.ShowDialog();
        }

        private void addDrugInThePanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DrugID = (int)DGVDrugs.CurrentRow.Cells[0].Value;
            clsBusinessBatches Checker = clsBusinessBatches.FindByDrugID(DrugID);

            if (Checker != null)
            {
                PanelCounter++;
                LBLPanel.Text = PanelCounter.ToString();

                if (TempPanel.Exists(Temp => Temp.DrugID == DrugID))
                {
                    CtLinvoiceDetails Temp = TempPanel.Find(T => T.DrugID == DrugID);

                    if ((clsBusinessBatches.SumOfDrugs(Temp.DrugID) - Temp.Quantity) == 0)
                    {
                        PanelCounter--;
                        LBLPanel.Text = PanelCounter.ToString();
                        MessageBox.Show("The Drug Is Out Of Stock Now ! , Report For More Quantity Please . ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Temp.SetBatches();
                    Temp._LoadData();
                }
                else
                {
                    TempPanel.Add(new CtLinvoiceDetails(DrugID));
                    CtLinvoiceDetails Temp = TempPanel.Find(T => T.DrugID == DrugID);
                    Temp.SetBatches();
                    Temp._LoadData();
                }
            }
            else
            {
                MessageBox.Show("The Drug Is Not In The Stock Any More Please report For More ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void showDrugInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowDrugInfo DrugInfo = new FrmShowDrugInfo((int)DGVDrugs.CurrentRow.Cells[0].Value);
            DrugInfo.Show();
        }

        private void TBSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void NotificationBTN_Click(object sender, EventArgs e)
        {
            NotificationPic.Visible = !(NotificationPic.Visible);
            LayoutPanelNotification.Visible = !(LayoutPanelNotification.Visible);
            LayoutPanelNotification.BringToFront();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            FrmHistory History = new FrmHistory();
            History.ShowDialog();
        }
    }
}

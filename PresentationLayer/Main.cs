using BusinessLayer;
using Guna.UI2.WinForms.Suite;
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

        private void _FillUserDataInLoad()
        {
            LBLUser.Text = clsCurrentUserLogin.CurrentUser.Username;
            LBLRole.Text = clsCurrentUserLogin.CurrentUser.CompositionRoles.RoleName;
            ProfilePicture.Load(clsCurrentUserLogin.CurrentUser.ImagePath);
            LBLDate.Text = DateTime.Now.ToShortDateString();
            LBLTime.Text = DateTime.Now.ToShortTimeString();
            LayoutPanelNotification.Visible = false;
            NotificationPic.Visible = false;
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            _FillUserDataInLoad();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            NotificationPic.Visible = (NotificationPic.Visible == false);
            LayoutPanelNotification.Visible = (LayoutPanelNotification.Visible == false);
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            MainStockForm frm = new MainStockForm();
            frm.ShowDialog();
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            frmManageUsers Users = new frmManageUsers();
            Users.ShowDialog();
        }
    }
}

using BusinessLayer;
using Guna.UI2.WinForms.Suite;
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

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            ReadAndWriteInFile.AddPictureInFolder(@"C:\Users\imad\Pictures\MyPhotos\277350598_1224823271257670_4271167348931403926_n");
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = (pictureBox9.Visible == false);
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

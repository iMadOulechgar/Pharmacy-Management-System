using Guna.UI2.WinForms.Suite;
using Pharmacy_Management_System.Notification.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

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
            LBLRole.Text = clsBusinessRoles.GetRoleNameByID(1);
            LBLUser.Text = "Imad Oulechgar";
            LBLDate.Text = DateTime.Now.ToShortDateString();
            LBLTime.Text = DateTime.Now.ToShortTimeString();
            LayoutPanelNotification.Visible = false;
            pictureBox9.Visible = false;
            LayoutPanelNotification.HorizontalScroll.Enabled = false;
            LayoutPanelNotification.HorizontalScroll.Visible = false;
            
            for (int i = 1; i <= 5 ; i++)
            {
                ctlNotification Not = new ctlNotification();
                Not.FillControleWithData("Title : "+i,"Description");
                LayoutPanelNotification.Controls.Add(Not);
            }

            LBLNotificationNum.Text = LayoutPanelNotification.Controls.Count.ToString();

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = (pictureBox9.Visible == false);
            LayoutPanelNotification.Visible = (LayoutPanelNotification.Visible == false);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            LBLRole.Text = "Admin";
            LBLUser.Text = "Imad Oulechgar";
            LBLDate.Text = DateTime.Now.ToShortDateString();
            LBLTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}

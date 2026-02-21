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

namespace Pharmacy_Management_System.Users
{
    public partial class Add_EditFrm : Form
    {
        public Add_EditFrm()
        {
            InitializeComponent();
            LBLTitle.Text = "Add New User";
            this.Text = "Add New User";
        }

        public Add_EditFrm(string Username)
        {
            InitializeComponent();
            LBLTitle.Text = "Update User";
            this.Text = "Update User";
            addAndEditUserCtl1._Users = clsBusinessUsers.FindUserByUsername(Username);
        }

        public void ThisClose()
        {
            this.Close();
        }

        private void Add_EditFrm_Load(object sender, EventArgs e)
        {
            addAndEditUserCtl1._FillDataInControle();
            addAndEditUserCtl1.CloseForm += ThisClose;
        }

        private void addAndEditUserCtl1_Load(object sender, EventArgs e)
        {

        }
    }
}

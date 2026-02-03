using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Pharmacy_Management_System.Users
{
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
        }

        private DataTable UsersDt;

        private void _LoadDataInGrid()
        {
            UsersDt = clsBusinessUsers.GetUsers();
            DGVUsers.DataSource = UsersDt;
            LBLCount.Text = DGVUsers.RowCount.ToString();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _LoadDataInGrid();
        }

        private void showUserDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDetails Details = new UserDetails((string)DGVUsers.CurrentRow.Cells[0].Value);
            Details.ShowDialog();
        }
    }
}

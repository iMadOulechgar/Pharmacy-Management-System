using BusinessLayer;
using Pharmacy_Management_System.Users.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pharmacy_Management_System.Users
{
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
        }

        private DataTable UsersDt;

        public void StoreMethodChangePicture(Action<string> Method)
        {
            AddAndEditUserCtl.ChangePicture += Method;
        }


        private void _FilerDataGridView()
        {
            string ColumnSelected = CBSelect.SelectedItem.ToString();
            string ColumnName = "";

            switch (ColumnSelected)
            {
                case "Username":
                    ColumnName = "Username";
                    break;
                case "RoleName":
                    ColumnName = "RoleName";
                    break;
                case "UserStatus":
                    ColumnName = "UserStatus";
                    break;
            }

            UsersDt.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", ColumnName, TBSearch.Text.Trim());
            LBLCount.Text = DGVUsers.RowCount.ToString();
        }

        private void _LoadDataInGrid()
        {

            UsersDt = clsBusinessUsers.GetUsers();
            DGVUsers.DataSource = UsersDt;
            LBLCount.Text = DGVUsers.RowCount.ToString();
            CBSelect.SelectedIndex = 0;
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Add_EditFrm Add = new Add_EditFrm();
            Add.ShowDialog();
            frmManageUsers_Load(null, null);
        }

        private void editUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_EditFrm Add = new Add_EditFrm((string)DGVUsers.CurrentRow.Cells[0].Value);
            Add.ShowDialog();
            frmManageUsers_Load(null, null);
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Wanna Delete This User?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsBusinessUsers.DeleteUserByUserID((string)DGVUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("The User Has Being Deleted Successfly ","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                    frmManageUsers_Load(null, null);
                }
            }
        }

        private void activeUserAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsActive = (string)DGVUsers.CurrentRow.Cells[2].Value == "ACTIVE" ? true : false;
            string Username = (string)DGVUsers.CurrentRow.Cells[0].Value;

            if (IsActive)
            {
                if(MessageBox.Show("Are You Sure You Wanna InActive This User From Being Acive?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsBusinessUsers.SwitchFromActiveToInactiver(IsActive, Username))
                        MessageBox.Show("The User Has Being InActivated", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    else
                        return;
                }
            }
            else
            {
                if (MessageBox.Show("Are You Sure You Wanna Active This User From Being InAcive?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsBusinessUsers.SwitchFromActiveToInactiver(IsActive, Username))
                        MessageBox.Show("The User Has Being Activated", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    else
                        return;
                }
            }
            frmManageUsers_Load(null, null);
        }

        private void TBSearch_TextChanged(object sender, EventArgs e)
        {
            _FilerDataGridView();
        }

        private void CBSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBSelect.Text == "UserStatus")
            {
                TBSearch.Visible = false;
                CBStatus.Visible = true;
            }
            else
            {
                TBSearch.Visible = true;
                CBStatus.Visible = false;
            }
        }

        private void CBStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBStatus.Text == "Active")
            {
                UsersDt.DefaultView.RowFilter = "UserStatus = 'Active'";
            }
            else
            {
                UsersDt.DefaultView.RowFilter = "UserStatus = 'InActive'";
            }

            LBLCount.Text = DGVUsers.RowCount.ToString();
        }
    }
}

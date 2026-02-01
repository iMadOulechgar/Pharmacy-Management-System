using BusinessLayer;
using Pharmacy_Management_System.Validation_AllSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.Login
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }
        private bool CheckIfDataAlreadyInRegistry()
        {
            if (clsRememberMe.CheckIsAlreadyInRegistry(TBUserName.Text.Trim(), TBPassword.Text.Trim()))
                return true;

            return false;
        }

        private void _Login()
        {
            bool IsActive = false;

            Main DashBoard = new Main();

            clsBusinessUsers _User = clsBusinessUsers.FindUserByUsernameAndPassword(TBUserName.Text.Trim(), TBPassword.Text.Trim(),ref IsActive);
            
            if (_User != null)
            {
                if (IsActive)
                {
                    clsCurrentUserLogin.CurrentUser = _User;

                    if (CBRememberMe.Checked)
                    {
                        if (!CheckIfDataAlreadyInRegistry())
                        {
                            clsRememberMe.RememberUsernameAndPassword(TBUserName.Text.Trim(), TBPassword.Text.Trim());
                        }
                    }

                    DashBoard.ShowDialog();
                }   
                else
                    MessageBox.Show("The User Is Not Active Contact Admin . ", "Login Faild", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Username Or Password Wrong Try Again", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            string Password = "", Username = "";

            if (clsRememberMe.GetStoredCredential(ref Username , ref Password))
            {
                TBUserName.Text = Username;
                TBPassword.Text = Password;
                CBRememberMe.Enabled = true;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            _Login();
        }
    }
}

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
using System.IO;
using Pharmacy_Management_System.Login;

namespace Pharmacy_Management_System.Users.Controles
{
    public partial class AddAndEditUserCtl : UserControl
    {
        public AddAndEditUserCtl()
        {
            InitializeComponent();
        }

        public static event Action<string> ChangePicture;
        public event Action CloseForm;

        public clsBusinessUsers _Users = null;

        void SetRoleInComboBox()
        {
            DataTable RolesTable = clsBusinessRoles.GetAllRoles();

            foreach (DataRow Row in RolesTable.Rows)
            {
                CBRoles.Items.Add(Row["RoleName"]);
            }
        }

        public void _FillDataInControle()
        {
            SetRoleInComboBox();
            CBRoles.SelectedIndex = 0;
            CBStatus.SelectedIndex = 0;

            if (_Users != null)
            {
                TBUsername.Text = _Users.Username;
                CBRoles.SelectedIndex = _Users.RoleID - 1;
                CBStatus.SelectedIndex = _Users.IsActive ? 1 : 0;
                if (_Users.Gendor == 'M')
                    RBMale.Checked = true;
                else
                    RBFemale.Checked = true;
                   
                TBEmail.Text = _Users.Email;
                TBPassword.Text = _Users.Passwordhash;
                if(_Users.ImagePath != "")
                PictureProfile.ImageLocation = _Users.ImagePath;

                TBPassword.Enabled = false;
            }
            else
            {
                _Users = new clsBusinessUsers();
            }
        } 

        private void BTNRemove_Click(object sender, EventArgs e)
        {
            if (PictureProfile.Image != null)
                PictureProfile.Image = null;
            else
                MessageBox.Show("There Is Not Picture Too Remove!","Information!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private bool FillUserWithData()
        {
            if (TBUsername.Text != "" && TBUsername.TextLength >= 4)
                _Users.Username = TBUsername.Text.Trim();
            else
            {
                MessageBox.Show("Username Is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
               
            if(TBPassword.Text != "" && TBPassword.TextLength >= 4)
            {
                _Users.Passwordhash = clsConvertToHashPassword.ComputeHash(TBPassword.Text.Trim());
            }
            else
            {
                MessageBox.Show("Password Is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            _Users.RoleID = CBRoles.SelectedIndex + 1;
            _Users.IsActive = CBStatus.SelectedIndex == 1 ? true : false;
            if (RBMale.Checked)
                _Users.Gendor = 'M';
            else
                _Users.Gendor = 'F';

            if (clsValidation.ValidateEmail(TBEmail.Text.Trim()))
            {
                _Users.Email = TBEmail.Text.Trim();
            }
            else
            {
                MessageBox.Show("Something Wrong In Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_Users.ImagePath != PictureProfile.ImageLocation)
            {
                if (_Users.ImagePath != "")
                {
                    try
                    {
                        if (clsCurrentUserLogin.CurrentUser.ImagePath == _Users.ImagePath)
                        {
                            ChangePicture?.Invoke(PictureProfile.ImageLocation);
                        }

                        File.Delete(_Users.ImagePath);
                    }
                    catch (IOException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }

                if (PictureProfile.ImageLocation != "")
                {
                    string FilePath = PictureProfile.ImageLocation;
                    ReadAndWriteInFile.AddDrugPictureInFolder(ref FilePath);
                    _Users.ImagePath = FilePath;
                }
            }   

            return true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (FillUserWithData())
            {
                if (_Users.Save())
                {
                    MessageBox.Show("Data Saved Successfly", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("SomeThing Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TBUsername_Validating(object sender, CancelEventArgs e)
        {
            if (TBUsername.Text == "")
            {
                TBUsername.Focus();
                errorProvider1.SetIconAlignment(TBUsername,ErrorIconAlignment.MiddleRight);
            }
            errorProvider1.Clear();
        }

        private void BTNBrows_Click(object sender, EventArgs e)
        {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string FileName = openFileDialog1.FileName;
                    PictureProfile.ImageLocation = FileName;
                }
        }

        private void TBUsername_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBUsername.Text)) { 
                errorProvider1.SetError(TBUsername, "Fill Text Box");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CloseForm?.Invoke();
        }

        private void TBEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidation.ValidateEmail(TBEmail.Text.Trim()))
            {
                TBEmail.Focus();
                e.Cancel = false;
                errorProvider1.SetError(TBEmail, "Set Email In The Right Place");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void TBEmail_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBEmail.Text))
            {
                errorProvider1.SetError(TBEmail, "Can Not be Empty");
            }
        }
    }
}

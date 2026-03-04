using BusinessLayer;
using Pharmacy_Management_System.Login;
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

namespace Pharmacy_Management_System.Drug
{
    public partial class AddOrEditDrug : Form
    {
        private enum enMode { Add , Update};
        enMode Mode = enMode.Add;

        public AddOrEditDrug()
        {
            InitializeComponent();

            _Drug = new clsBusinessDrugs();
            Mode = enMode.Add;
        }

        public event Action LoadDataIn;

        clsBusinessDrugs _Drug;

        private void ChangeTitle()
        {
            if (Mode == enMode.Add)
            {
                LBLTitle.Text = "Add New Drug";
                this.Text = "AddNewDrug";
            }
            else
            {
                LBLTitle.Text = "Update Drug";
                this.Text = "UpdateDrug";
            }
        }

        void LoadDataInComboBox()
        {
            DataTable DrugForm = clsBusinessDrugForms.GetAllDrugForms();

            foreach (DataRow item in DrugForm.Rows)
            {
                CBDrugForm.Items.Add(item["DrugForm"]);
            }

            CBDrugForm.SelectedIndex = 0;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DrugPic.Image != null)
            {
                DrugPic.Image = null;
            }
            else
            {
                MessageBox.Show("There Is No Picture Too Remove :)","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Restart()
        {
            TBDrugName.Text = "";
            if (RBINActive.Checked)
                RBINActive.Checked = false;
            else
                RBActive.Checked = false;

            DrugPic.Image = null;
            CBDrugForm.SelectedIndex = 0;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            LoadDataIn?.Invoke();
            this.Close();
        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void AddOrEditDrug_Load(object sender, EventArgs e)
        {
            LoadDataInComboBox();
            ChangeTitle();
        }

        private void BTNBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog Open = new OpenFileDialog())
            {
                if (Open.ShowDialog() == DialogResult.OK)
                {
                    DrugPic.ImageLocation = Open.FileName;
                }
            }
        }

        private bool _SetData()
        {
            _Drug.CreatedByUserID = clsCurrentUserLogin.CurrentUser.UserID;

            if (TBDrugName.Text.Trim() != "")
                _Drug.DrugName = TBDrugName.Text.Trim();
            else
            {
                MessageBox.Show("The DrugName Is Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (DrugPic.Image != null)
            {
                string Pic = DrugPic.ImageLocation.ToString();
                ReadAndWriteInFile.AddDrugPictureInFolder(ref Pic);
                _Drug.PicturePath = Pic;
            }
            else
            {
                MessageBox.Show("The PictureBox Is Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!((RBActive.Checked != true && RBINActive.Checked != false) || (RBActive.Checked != false && RBINActive.Checked != true)))
            {
                MessageBox.Show("Check The Radio Buttons", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                _Drug.IsActive = (RBActive.Checked);
            }

            if (CBDrugForm.Text != "None")
            {
                _Drug.DrugFormID = CBDrugForm.SelectedIndex;
            }
            else
            {
                MessageBox.Show("Select Specific Drug Form ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(_SetData())
            {
                if(_Drug.Save())
                {    
                    MessageBox.Show("Data Saved Successfly :)","Confirm",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    
                    if(Mode == enMode.Add)
                    {
                        Mode = enMode.Update;
                        ChangeTitle();
                    }
                }
                else
                {
                    MessageBox.Show("Something Wrong ):", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}

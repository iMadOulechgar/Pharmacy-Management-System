using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.Users.Controles
{
    public partial class UserInfoCtrl : UserControl
    {
        public clsBusinessUsers UserInfo;
        public UserInfoCtrl()
        {
            InitializeComponent();
        }


        public void FillControlesData()
        {
            LBLUsername.Text = UserInfo.Username;
            LBLEmail.Text = UserInfo.Email;

            if (UserInfo.Gendor == 'M')
                LBLGendor.Text = "Male";
            else
                LBLGendor.Text = "Female";

            LBLRole.Text = UserInfo.CompositionRoles.RoleName;
            
            if(UserInfo.IsActive == true)
            {
                LBLStatus.Text = "Active";
                PictureStatus.Image = Properties.Resources.icons8_circle_50__1_;
            }
            else
            {
                LBLStatus.Text = "InActive";
                PictureStatus.Image = Properties.Resources.icons8_circle_50;
            }

            PictureProfile.Load(UserInfo.ImagePath);
        }

    }
}

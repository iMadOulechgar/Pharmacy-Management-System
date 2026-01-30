using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.Notification.Controles
{
    public partial class ctlNotification : UserControl
    {
        public ctlNotification()
        {
            InitializeComponent();
        }

        public void FillControleWithData(string Title , string Description)
        {
            LBLTitle.Text = Title;
            LBLDesc.Text = Description;
        }


        private void ctlNotification_Load(object sender, EventArgs e)
        {
            this.Width = this.Parent.Width - 25;
        }

    }
}

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

namespace Pharmacy_Management_System.Notification.Controles
{
    public partial class ctlNotification : UserControl
    {
        public ctlNotification()
        {
            InitializeComponent();
        }

        private string Drugname { get; set; }

        public void FillControleWithData(string Title , string Description,DateTime Dt,string Path)
        {
            Drugname = Title;
            LBLTitle.Text = Title;
            LBLDesc.Text = Description;
            LBLTime.Text = Dt.ToString();
            pictureBox1.ImageLocation = Path;
        }


        private void ctlNotification_Load(object sender, EventArgs e)
        {
            this.Width = this.Parent.Width - 25;
        }

        private void LBLDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (clsBusinessBatches.FindByDrugID(clsBusinessDrugs.FindByDrugName(Drugname).DrugId).Quantity > 10)
            {
                this.Dispose();
            }
            else
            {
                MessageBox.Show("You Cannot Delete This Notification , Please Report For More Drugs","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}

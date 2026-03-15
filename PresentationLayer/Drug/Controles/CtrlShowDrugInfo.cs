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

namespace Pharmacy_Management_System.Drug.Controles
{
    public partial class CtrlShowDrugInfo : UserControl
    {
        public CtrlShowDrugInfo()
        {
            InitializeComponent();
        }

        public clsBusinessDrugs _Drugs;

        public void _LoadInCtrl()
        {
            LBLDrugName.Text = _Drugs.DrugName;
            LBLIsActive.Text = _Drugs.IsActive ? "Yes" : "No";
            LBLDrugForm.Text = _Drugs.DrugForms.DrugForm.ToString();
            LBLPricePerUnit.Text = clsBusinessBatches.FindByDrugID(_Drugs.DrugId).PerchasePrice.ToString();
            LBLQuantity.Text = clsBusinessBatches.FindByDrugID(_Drugs.DrugId).Quantity.ToString();
            PBpicture.Load(_Drugs.PicturePath);
        }


    }
}

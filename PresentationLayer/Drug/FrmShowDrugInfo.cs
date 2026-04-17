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

namespace Pharmacy_Management_System.Drug
{
    public partial class FrmShowDrugInfo : Form
    {
        public FrmShowDrugInfo(string DrugName)
        {
            InitializeComponent();
            ctrlShowDrugInfo1._Drugs = clsBusinessDrugs.FindByDrugName(DrugName);
            ctrlShowDrugInfo1._LoadInCtrl();
        }

        public FrmShowDrugInfo(int DrugID)
        {
            InitializeComponent();

            ctrlShowDrugInfo1._Drugs = clsBusinessDrugs.FindByDrugID(DrugID);
            if (ctrlShowDrugInfo1._Drugs != null)
                ctrlShowDrugInfo1._LoadInCtrl();
            else
                MessageBox.Show("The Drug Is Not Found ): ");

            
        }

    }
}

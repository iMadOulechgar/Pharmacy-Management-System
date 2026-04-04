using BusinessLayer;
using Pharmacy_Management_System.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pharmacy_Management_System.invoices.Controles
{
    public partial class CtLinvoiceDetails : UserControl
    {
        public CtLinvoiceDetails()
        {
            InitializeComponent();
        }

        public DataTable TempTable = new DataTable();

        public CtLinvoiceDetails(int DrugID)
        {
            InitializeComponent();
            TempTable = clsBusinessBatches.GetAllDrugsAvailable(DrugID);
            this.DrugID = DrugID;
        }

        public static event Action<int> Delete;
        public List<int> BatchID;

        public void SetBatches()
        {

            DataView DT = TempTable.DefaultView;
            DT.RowFilter = $"Quantity > 0 AND DrugID = {DrugID}";
            TempTable = DT.ToTable();

            BatchID.Add((int)TempTable.Rows[0][0]);
            int TempQuantity = (int)TempTable.Rows[0][2];
            TempTable.Rows[0][2] = TempQuantity - 1;
        }

        public int DrugID { get; set; }

        public void _LoadData()
        {
            clsBusinessDrugs Drugs = clsBusinessDrugs.FindByDrugID(DrugID);
            PBPath.Load(Drugs.PicturePath);
            LBLDrugname.Text = Drugs.DrugName;
            LBLDrugForm.Text = Drugs.DrugForms.DrugForm.ToString();
            LBLPricePerUnit.Text = Convert.ToDecimal(clsBusinessBatches.FindByDrugID(DrugID).SellingPrice).ToString();
            LBLUsername.Text = clsCurrentUserLogin.CurrentUser.Username.ToString();
            LBLQuantity.Text = BatchID.Count.ToString();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Delete?.Invoke(DrugID);
            this.Dispose();
        }
    }
}

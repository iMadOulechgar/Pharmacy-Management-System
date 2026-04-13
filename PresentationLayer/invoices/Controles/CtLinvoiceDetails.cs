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
        public List<Tuple<int,decimal,int,int>> Cards = new List<Tuple<int, decimal, int, int>>();

        public void _RestDataTooDefault()
        {
            Cards.Clear();
            this.Quantity = 0;
            this.DrugID = 0;
        } 

        public void SetBatches()
        {
            DataRow Row = TempTable.AsEnumerable().FirstOrDefault(R => (int)R["Quantity"] > 0);

            if(Row != null)
            {
                int BatchID = (int)Row[0];
                decimal Price = Convert.ToDecimal(Row[4]);
                int DrugID = (int)Row[1];
                this.Quantity += 1;

                Row["Quantity"] = (int)Row["Quantity"] - 1;

                if (Cards.Exists(Ex => Ex.Item4 == BatchID))
                {
                    var Temp = Cards.Find(Ex => Ex.Item4 == BatchID);
                    Cards.Remove(Temp);
                    Cards.Add(new Tuple<int, decimal, int, int>(Temp.Item1 + 1, Convert.ToDecimal(Row[4]) + Price, DrugID, BatchID));
                }
                else
                {
                    Cards.Add(new Tuple<int, decimal, int, int>(1, Price, DrugID, BatchID));
                }
            }
        }

        public int DrugID { get; set; }
        public int Quantity { get; set; }

        public void _LoadData()
        {
                clsBusinessDrugs Drugs = clsBusinessDrugs.FindByDrugID(DrugID);
                PBPath.Load(Drugs.PicturePath);
                LBLDrugname.Text = Drugs.DrugName;
                LBLDrugForm.Text = Drugs.DrugForms.DrugForm.ToString();
                LBLUsername.Text = clsCurrentUserLogin.CurrentUser.Username.ToString();
                LBLPricePerUnit.Text = Convert.ToDecimal(clsBusinessBatches.FindByDrugID(DrugID).SellingPrice * Quantity).ToString();
                LBLQuantity.Text = Quantity.ToString();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Delete?.Invoke(DrugID);
            this.Dispose();
        }
    }
}

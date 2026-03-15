using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsBusinessBatches
    {

        enum enMode { Add , Update};
        enMode Mode = enMode.Add;

        public int ButchesID { get; set; }
        public int DrugID { get; set; }

        public clsBusinessDrugs CompDrugs;
        public int Quantity { get; set; }
        public int OldQuantity { get; set; }
        public decimal PerchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedByUserID { get; set; }


        public clsBusinessBatches()
        {
            ButchesID = -1;
            DrugID = -1;
            Quantity = -1;
            OldQuantity = -1;
            PerchasePrice = -1;
            SellingPrice = -1;
            ExpirationDate = default(DateTime);
            CreatedAt = default(DateTime);
            CreatedByUserID = -1;

            Mode = enMode.Add;
        }

        public clsBusinessBatches(int BatchID, int DrugID, int Quantity, decimal PurchasePrice, decimal SellingPrice,
            DateTime ExpirationDate, DateTime CreatedAt, int OldQuantity, int CreatedByUserID)
        {
            this.ButchesID = BatchID;
            this.DrugID = DrugID;
            this.CompDrugs = clsBusinessDrugs.FindByDrugID(DrugID);
            this.Quantity = Quantity;
            this.PerchasePrice = PurchasePrice;
            this.SellingPrice = SellingPrice;
            this.ExpirationDate = ExpirationDate;
            this.CreatedAt = CreatedAt;
            this.CreatedByUserID = CreatedByUserID;
            this.OldQuantity = OldQuantity;

            Mode = enMode.Update;
        }

        public static clsBusinessBatches FindByDrugID(int DrugID)
        {
            int BatchID = -1, Quantity = -1, OldQuantity = -1, CreatedByUserID = -1;
            decimal PurchasePrice = -1, SellingPrice = -1;
            DateTime ExpirationDate = default(DateTime), CreatedAt = default(DateTime);

            if (clsDataAccessBatches.Find(ref BatchID,DrugID,ref Quantity,ref PurchasePrice,ref SellingPrice,
                ref ExpirationDate,ref CreatedAt , ref OldQuantity , ref CreatedByUserID))
            {
                return new clsBusinessBatches(BatchID, DrugID, Quantity, PurchasePrice, SellingPrice, ExpirationDate,
                    CreatedAt, OldQuantity, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewBatche()
        {
            if (clsDataAccessBatches.ADDNewBatch(this.DrugID, this.Quantity, this.PerchasePrice, this.SellingPrice, this.ExpirationDate, 
                this.CreatedAt , this.OldQuantity , this.CreatedByUserID) > 0)
                return true;
            else
                return false;
        } 

        public static DataTable GetAllBatches()
        {
            return clsDataAccessBatches.GetAllBatches();
        }

        public static int GetOldQuantityByDrugID(int DrugID)
        {
            return clsDataAccessBatches.GetOldQuantity(DrugID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if (_AddNewBatche())
                    {
                        return true;
                    }
                    break;
            }

            return false;   
        }


    }
}

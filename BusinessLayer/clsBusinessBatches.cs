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
        public decimal PerchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime CreatedAt { get; set; }

        public clsBusinessBatches()
        {
            ButchesID = -1;
            DrugID = -1;
            Quantity = -1;
            PerchasePrice = -1;
            SellingPrice = -1;
            ExpirationDate = default(DateTime);

            Mode = enMode.Add;
        }

        private bool _AddNewBatche()
        {
            if (clsDataAccessBatches.ADDNewBatch(this.DrugID, this.Quantity, this.PerchasePrice, this.SellingPrice, this.ExpirationDate, this.CreatedAt) > 0)
                return true;
            else
                return false;
        } 

        public static DataTable GetAllBatches()
        {
            return clsDataAccessBatches.GetAllBatches();
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

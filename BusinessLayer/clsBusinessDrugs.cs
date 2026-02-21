using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsBusinessDrugs
    {

        private enum enMode { Add , Update};
        enMode Mode = enMode.Add;

        public string DrugName { get; set; }
        public int DrugFormID { get; set; }

        public clsBusinessDrugForms DrugForms;
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }
        public string PicturePath { get; set; }

        public clsBusinessDrugs()
        {
            this.DrugName = "";
            this.DrugFormID = -1;
            this.IsActive = false;
            this.CreatedByUserID = -1;
            this.PicturePath = "";

            Mode = enMode.Add;
        }

        private bool _AddDrug()
        {
            if (clsDataAccessDrugs.AddNewDrug(this.DrugName, this.DrugFormID, this.IsActive, this.CreatedByUserID, this.PicturePath) > 0)
                return true;
            else
                return false;   
        }

        public static DataTable GetDrugs()
        {
            return clsDataAccessDrugs.GetAllDrugs();
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if (_AddDrug())
                    {
                        return true;
                    }
                    break;
                case enMode.Update:
                    break;
                default:
                    break;
            }

            return false;
        }

    }
}

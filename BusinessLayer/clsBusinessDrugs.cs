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

        public enum enMode { Add , Update};
        public enMode Mode = enMode.Add;

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


        public static int GetDrugIDByName(string Name)
        {
            return clsDataAccessDrugs.GetDrugIDByName(Name);
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

        public static int TotalDrugs()
        {
            return clsDataAccessDrugs.GetTotalOfDrugs();
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.Add:
                    if (_AddDrug())
                    {
                        Mode = enMode.Update;
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

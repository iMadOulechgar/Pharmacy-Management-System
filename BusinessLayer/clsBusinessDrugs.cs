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

        public int DrugId {  get; set; }
        public string DrugName { get; set; }
        public int DrugFormID { get; set; }

        public clsBusinessDrugForms DrugForms;
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }
        public string PicturePath { get; set; }

        public clsBusinessDrugs(int drugid , string drugname , int drugformid , bool isactive , int createdbyuser , string pathpic)
        {
            this.DrugId = drugid;
            this.DrugName = drugname;
            this.DrugFormID = drugformid;
            this.DrugForms = clsBusinessDrugForms.FindByDrugFormId(drugformid);
            this.IsActive = isactive;
            this.CreatedByUserID = createdbyuser;
            this.PicturePath = pathpic;
            
            Mode = enMode.Update;
        }

        public clsBusinessDrugs()
        {
            this.DrugName = "";
            this.DrugFormID = -1;
            this.IsActive = false;
            this.CreatedByUserID = -1;
            this.PicturePath = "";

            Mode = enMode.Add;
        }

        public static clsBusinessDrugs FindByDrugName(string Drugname)
        {
            int drugid = -1, drugformid = -1, createdbyuser = -1;
            bool isactive = false;
            string pathpic = "";

            if (clsDataAccessDrugs.Find(ref drugid, Drugname,ref drugformid,ref isactive,ref createdbyuser,ref pathpic))
            {
                return new clsBusinessDrugs(drugid, Drugname, drugformid, isactive, createdbyuser, pathpic);
            }
            else
            {
                return null;
            }
        }

        public static clsBusinessDrugs FindByDrugID(int DrugID)
        {
            string drugName = "";
            int drugformid = -1, createdbyuser = -1;
            bool isactive = false;
            string pathpic = "";

            if (clsDataAccessDrugs.Find(DrugID, ref drugName, ref drugformid, ref isactive, ref createdbyuser, ref pathpic))
            {
                return new clsBusinessDrugs(DrugID, drugName, drugformid, isactive, createdbyuser, pathpic);
            }
            else
            {
                return null;
            }
        }

        public static bool CheckDrugIsExistsByDrugName(string Drugname)
        {
            return clsDataAccessDrugs.IsDrugExists(Drugname);
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

        public static int GetAllAvailableDrugs()
        {
            return clsDataAccessDrugs.GetDrugAvailableInStock();
        }

        public static DataTable GetAllDrugsForSale()
        {
            return clsDataAccessDrugs.GetAllInvoicesDrugs();
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

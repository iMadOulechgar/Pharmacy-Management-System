using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsBusinessDrugForms
    {

        public int DrugFormId { get; set; }
        public string DrugForm {  get; set; }

        public clsBusinessDrugForms(int drugformid , string drugform)
        {
            this.DrugFormId = drugformid;
            this.DrugForm = drugform;
        }

        public static DataTable GetAllDrugForms()
        {
            return clsDataAccessDrugForms.DrugForms();
        }

        public static int GetDrugFormID(string DrugName)
        {
            return clsDataAccessDrugForms.GetDrugIdByName(DrugName);
        }

        public static clsBusinessDrugForms FindByDrugFormId(int DrugFormId)
        {
            string DrugForm = "";

            if (clsDataAccessDrugForms.Find(DrugFormId,ref DrugForm))
            {
                return new clsBusinessDrugForms(DrugFormId, DrugForm);
            }
            else
            {
                return null;
            }
        }



    }
}

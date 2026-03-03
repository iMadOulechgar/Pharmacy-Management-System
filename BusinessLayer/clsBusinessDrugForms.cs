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
        public static DataTable GetAllDrugForms()
        {
            return clsDataAccessDrugForms.DrugForms();
        }

        public static int GetDrugFormID(string DrugName)
        {
            return clsDataAccessDrugForms.GetDrugIdByName(DrugName);
        }



    }
}

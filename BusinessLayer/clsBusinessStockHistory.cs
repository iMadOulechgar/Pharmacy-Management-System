using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsBusinessStockHistory
    {

        public static DataTable GetAllStock()
        {
            return clsDataAccessStockHistory.GetDataFromStockHistory();
        }




    }
}

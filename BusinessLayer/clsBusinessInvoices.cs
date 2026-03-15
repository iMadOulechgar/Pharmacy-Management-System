using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsBusinessInvoices
    {
        public static int GetTotalSales()
        {
            return clsDataAccessInvoices.TotalSales();
        }


    }
}

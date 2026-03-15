using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsDataAccessInvoices
    {

        public static int TotalSales()
        {
            int Result = 0;

            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string Query = "select Sum(TotalAmount) from Invoices;";

                using (SqlCommand cmd = new SqlCommand(Query,con))
                {
                   con.Open();

                   object Obj = cmd.ExecuteScalar();

                   if (DBNull.Value != Obj)
                   {
                        Result = (int)Obj;
                   }
                       
                }
            }

            return Result;  
        }





    }
}

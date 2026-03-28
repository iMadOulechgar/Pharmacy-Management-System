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
    static public class clsDataAccessInvoicesDetails
    {

        public static bool ADDInvoices(DataTable Table , int InvoiceNumber , int PharmacistID , decimal TotalAmount,DateTime CreatedAt)
        {
            int Result = 0;

            try
            {
                using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_AddInvoices", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@TempTable", Table);
                        cmd.Parameters.AddWithValue("@InvoiceNumbers", InvoiceNumber);
                        cmd.Parameters.AddWithValue("@PharmacyID", PharmacistID);
                        cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                        cmd.Parameters.AddWithValue("@CreateAt", CreatedAt);

                        con.Open();

                        Result = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return (Result != 0); 
        }




    }
}

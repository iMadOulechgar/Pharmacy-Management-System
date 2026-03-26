using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsDataAccessinvoices
    {
        public static int AddInvoice(int NumbersOfDrugs , int PharmacistId , decimal TotalAmount , DateTime CreateAt)
        {   
            int InvoiceID = 0;

            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("ST_InsertInvoice", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@InvoiceNumber", NumbersOfDrugs);
                    cmd.Parameters.AddWithValue("@PharmacistID", PharmacistId);
                    cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                    cmd.Parameters.AddWithValue("@CreatedAt", CreateAt);

                    SqlParameter Output = new SqlParameter("@invoiceID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    cmd.Parameters.Add(Output);
                    con.Open();

                    cmd.ExecuteNonQuery();

                    InvoiceID = (int)cmd.Parameters["@invoiceID"].Value;
                }
            }

            return InvoiceID;
        }

        public static int GetTotalSales()
        {
            int result = 0;
            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string Query = "select sum(TotalAmount) from Invoices";

                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    con.Open();

                    object OBJ = cmd.ExecuteScalar();

                    if (DBNull.Value != OBJ)
                    {
                        result = Convert.ToInt32(OBJ);
                    }
                }
            }
            return result;
        }





    }
}

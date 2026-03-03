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
    public static class clsDataAccessBatches
    {

        public static int ADDNewBatch(int DrugID , int Quantity , decimal PurchasePrice , decimal SellingPrice , 
            DateTime ExpirationDate , DateTime CreatedAt)
        {
            int Result = 0;

            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_DrugBatches",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@drugid", DrugID);
                    cmd.Parameters.AddWithValue("@quantity", Quantity);
                    cmd.Parameters.AddWithValue("@purchasePrice", PurchasePrice);
                    cmd.Parameters.AddWithValue("@SellingPrice", SellingPrice);
                    cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                    cmd.Parameters.AddWithValue("@createdate", CreatedAt);

                    SqlParameter Output = new SqlParameter("@batcheid", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    cmd.Parameters.Add(Output);

                    con.Open();

                    cmd.ExecuteReader();

                    Result = (int)cmd.Parameters["@batcheid"].Value;
                }
            }

            return Result;
        }

        public static DataTable GetAllBatches()
        {
            DataTable Dt = new DataTable();

            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string Query = "SELECT * FROM DrugBatches_View";

                using (SqlCommand cmd = new SqlCommand(Query,con))
                {
                    con.Open() ;

                    SqlDataReader reader = cmd.ExecuteReader();
                    Dt.Load(reader);
                }
            }

            return Dt;
        }



    }
}

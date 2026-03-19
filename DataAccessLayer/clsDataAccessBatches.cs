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
            DateTime ExpirationDate , DateTime CreatedAt,int OldQuantity , int CreatedByUserID)
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
                    cmd.Parameters.AddWithValue("@OldQuantity", OldQuantity);
                    cmd.Parameters.AddWithValue("@CreatedByUserID",CreatedByUserID);

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

        public static int GetOldQuantity(int DrugID)
        {
            int Result = 0;
            
            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string Query = "SELECT dbo.F_GetOldQuatity(@Imad);";

                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    cmd.Parameters.AddWithValue("@Imad", DrugID);

                    con.Open();

                    object OJ = cmd.ExecuteScalar(); 
                    if(OJ != null) 
                        Result = (int)OJ;
                }
            }

            return Result;
        }

        public static bool Find(ref int BatchID ,int DrugID, ref int Quantity, ref decimal PurchasePrice, ref decimal SellingPrice,
            ref DateTime ExpirationDate, ref DateTime CreatedAt, ref int OldQuantity, ref int CreatedByUserID)
        {
            bool Result = false;

            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string Query = "select top 1 * from DrugBatches where Quantity > 0 and DrugID = @drugid order by BatchID ASC";

                using (SqlCommand cmd = new SqlCommand(Query,con))
                {
                    cmd.Parameters.AddWithValue("@drugid", DrugID);

                    con.Open();

                    SqlDataReader Reader = cmd.ExecuteReader();

                    if (Reader.Read())
                    {
                        Result = true;
                        BatchID = (int)Reader["BatchID"];
                        Quantity = (int)Reader["Quantity"];
                        PurchasePrice = (decimal)Reader["PurchasePricePerUnit"];
                        SellingPrice = (decimal)Reader["SellingPricePerUnit"];
                        ExpirationDate = (DateTime)Reader["ExpirationDate"];
                        CreatedAt = (DateTime)Reader["CreatedAt"];

                        if (DBNull.Value == Reader["OldQuatity"])
                            OldQuantity = 0;
                        else
                            OldQuantity = (int)Reader["OldQuatity"];

                        CreatedByUserID = (int)Reader["CreatedByUserID"];
                    }
                }
            }

            return Result;
        }

    }
}

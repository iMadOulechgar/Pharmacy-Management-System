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
    public static class clsDataAccessNotification
    {
        public static int AddNewNotification(string Title , string desc , DateTime DT , string PicturePath , int DrugID)
        {
            int Result = 0;

            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_AddAlert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Title", Title);
                    cmd.Parameters.AddWithValue("@Desc", desc);
                    cmd.Parameters.AddWithValue("@Alertime", DT);
                    cmd.Parameters.AddWithValue("@PicturePath", PicturePath);
                    cmd.Parameters.AddWithValue("@DrugID", DrugID);

                    SqlParameter output = new SqlParameter("@AlertID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    cmd.Parameters.Add(output);

                    con.Open();

                    cmd.ExecuteReader();

                    Result = (int)cmd.Parameters["@AlertID"].Value;
                }
            }

            return Result;
        }

        public static bool DeleteNotification(int drugID)
        {
            int result = 0;

            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string Query = @"delete from Alert where
                                 (select sum(DrugBatches.Quantity) as total from DrugBatches where DrugBatches.DrugID = @DrugID) > 10";
                using (SqlCommand cmd = new SqlCommand(Query,con))
                {
                    cmd.Parameters.AddWithValue("@DrugID",drugID);

                    con.Open();

                    result = cmd.ExecuteNonQuery();
                }
            }

            return (result > 0);
        }
        


    }
}

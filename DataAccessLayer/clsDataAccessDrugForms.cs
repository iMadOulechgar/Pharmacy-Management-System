using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsDataAccessDrugForms
    {

        public static DataTable DrugForms()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {

                string Query = "SELECT * FROM DrugForms;";

                using (SqlCommand cmd = new SqlCommand(Query,con))
                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            return dt;
        }

        public static int GetDrugIdByName(string DrugName)
        {
            int Result = -1;

            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string Query = "SELECT DrugFormID FROM DrugForms WHERE DrugForm = @DN";

                using (SqlCommand cmd = new SqlCommand(Query,con))
                {
                    cmd.Parameters.AddWithValue("@DN", DrugName);

                    object OJ = cmd.ExecuteScalar();

                    if(OJ != null)
                      Result = (int)OJ;
                }
            }

            return Result;
        }

        public static bool Find(int drugformid , ref string FormName)
        {
            bool Result = false;

            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string Query = "SELECT * FROM DrugForms WHERE DrugFormID = @ID";

                using (SqlCommand cmd = new SqlCommand(Query,con))
                {
                    cmd.Parameters.AddWithValue("@ID",drugformid);

                    con.Open();

                    SqlDataReader Reader = cmd.ExecuteReader();

                    if (Reader.Read())
                    {
                        Result = true;
                        FormName = (string)Reader["DrugForm"];
                    }
                    Reader.Close();
                }
            }
            return Result;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsDataAccessDrugs
    {
        public static DataTable GetAllDrugs()
        {
            DataTable Table = new DataTable();

            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string Query = "SELECT * FROM Drug_View";

                using (SqlCommand cmd = new SqlCommand(Query,con))
                {
                    con.Open();

                    SqlDataReader Reader = cmd.ExecuteReader();
                    Table.Load(Reader);
                }
            }

            return Table;
        }

        public static int AddNewDrug(string DrugName , int FormID , bool isactive , int CreatedbyUserID , string Path)
        {
            int drugID = 0;

            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_ADDNewDrug",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DrugName", DrugName);
                    cmd.Parameters.AddWithValue("@DrugFormID", FormID);
                    cmd.Parameters.AddWithValue("@IsActive", isactive);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedbyUserID);
                    cmd.Parameters.AddWithValue("@PicturePath", Path);
                    SqlParameter Output = new SqlParameter("@DrugID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    cmd.Parameters.Add(Output);

                    con.Open();

                    cmd.ExecuteNonQuery();

                    drugID = (int)cmd.Parameters["@DrugID"].Value;
                }
            }

            return drugID;
        }

        public static int GetTotalOfDrugs()
        {
            int Total = 0;

            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string Query = "SELECT COUNT(*) FROM Drugs;";

                using (SqlCommand cmd = new SqlCommand(Query,con))
                {
                    con.Open();

                    Total = (int)cmd.ExecuteScalar();
                }
            }

            return Total;
        }

        public static int GetDrugIDByName(string Name)
        {
            int Result = 0;

            using (SqlConnection Con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string Query = "SELECT DrugID FROM Drugs WHERE DrugName = @DrugName";

                using (SqlCommand cmd = new SqlCommand(Query,Con))
                {
                    cmd.Parameters.AddWithValue("@DrugName",Name);
                    
                    Con.Open();

                    object OJ = cmd.ExecuteScalar();

                    if(OJ != null)
                        Result = (int)OJ;
                }
            }

            return Result;
        }


    }
}

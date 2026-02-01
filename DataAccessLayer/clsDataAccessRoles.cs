using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsDataAccessRoles
    {
        public static string GetRoleName(int RoleID)
        {
            string RoleName = "";
            
            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string Query = "SELECT RoleName FROM Roles WHERE RoleID = @ID";

                using (SqlCommand cmd = new SqlCommand(Query,con))
                {
                    cmd.Parameters.AddWithValue("@ID", RoleID);

                    try
                    {
                        con.Open();

                        object Obj = cmd.ExecuteScalar();

                        if (Obj != null) 
                            RoleName = Obj.ToString();

                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }

            return RoleName;
        }

        public static bool FindRoles(int RoleID , ref string RoleName)
        {
            bool result = false;

            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string Query = "SELECT RoleID , RoleName FROM Roles WHERE RoleID = @RoleID";

                using (SqlCommand cmd = new SqlCommand(Query,con))
                {
                    cmd.Parameters.AddWithValue("@RoleID",RoleID);

                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        RoleName = (string)reader["RoleName"];
                        result = true;
                    }
                }
            }

            return result;
        }

    }
}

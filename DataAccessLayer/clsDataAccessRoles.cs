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
    }
}

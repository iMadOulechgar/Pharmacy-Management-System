using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsDataAccessUsers
    {
        public static bool LoginUser(string Username , string Password , ref bool IsActive)
        {
            bool Result = false;

            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string Query = "SELECT * FROM Users WHERE Username = @username and Passwordhash = @password";

                using (SqlCommand Cmd = new SqlCommand(Query,con))
                {
                    Cmd.Parameters.AddWithValue("@username", Username);
                    Cmd.Parameters.AddWithValue("@password", Password);

                    try
                    {
                        con.Open();

                        SqlDataReader Reader = Cmd.ExecuteReader();

                        if (Reader.Read())
                        {
                            Result = true;
                            IsActive = (bool)Reader["IsActive"];
                        }
                    }
                    catch(Exception ex) 
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }

            return Result;
        }





    }
}

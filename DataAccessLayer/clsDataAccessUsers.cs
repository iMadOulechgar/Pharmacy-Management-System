using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
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

        public static bool Find(int UserID , ref string UserName , ref string Password,ref int RoleID , 
            ref bool IsActive , ref string ImagePath , ref char Gendor)
        {
            bool result = false;

            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string Query = "SELECT * FROM Users WHERE UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(Query,con))
                {
                    cmd.Parameters.AddWithValue("@UserID",UserID);

                    SqlDataReader Reader = cmd.ExecuteReader();

                    if (Reader.Read())
                    {
                        result = true;

                        UserName = (string)Reader["Username"];
                        Password = (string)Reader["Passwordhash"];
                        RoleID = (int)Reader["RoleID"];
                        IsActive = (bool)Reader["IsActive"];
                        ImagePath = (string)Reader["ImagePath"];
                        Gendor = (char)Reader["Gendor"];
                    }
                }
            }

            return result;
        }

        public static bool Find(ref int UserID, string UserName, string Password, ref int RoleID,
            ref bool IsActive, ref string ImagePath, ref char Gendor)
        {
            bool result = false;

            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string Query = "SELECT * FROM Users WHERE Username = @Username and Passwordhash = @Password";

                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", UserName);
                    cmd.Parameters.AddWithValue("@Password", Password);

                    con.Open();

                    SqlDataReader Reader = cmd.ExecuteReader();

                    if (Reader.Read())
                    {
                        result = true;

                        UserID = (int)Reader["UserID"];
                        RoleID = (int)Reader["RoleID"];
                        IsActive = (bool)Reader["IsActive"];
                        ImagePath = (string)Reader["ImagePath"];
                        Gendor = Convert.ToChar(Reader["Gendor"].ToString());
                    }
                }
            }

            return result;
        }

        public static DataTable GetAllUsers()
        {
            DataTable Dt = new DataTable();

            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string Query = "SELECT * FROM Users";

                using (SqlCommand cmd = new SqlCommand(Query , con))
                {
                    con.Open();

                    SqlDataReader Reader = cmd.ExecuteReader();
                      Dt.Load(Reader);
                }
            }

            return Dt;
        } 

    }
}

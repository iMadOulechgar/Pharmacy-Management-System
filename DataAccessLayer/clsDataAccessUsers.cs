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
            ref bool IsActive , ref string ImagePath , ref char Gendor , ref string Email)
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
                        Email = (string)Reader["Email"];
                        Gendor = (char)Reader["Gendor"];
                    }
                }
            }

            return result;
        }

        public static bool Find(ref int UserID,string UserName, ref string Password, ref int RoleID,
           ref bool IsActive, ref string ImagePath, ref char Gendor, ref string Email)
        {
            bool result = false;

            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string Query = "SELECT * FROM Users WHERE Username = @Username";

                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", UserName);

                    con.Open();

                    SqlDataReader Reader = cmd.ExecuteReader();

                    if (Reader.Read())
                    {
                        result = true;

                        UserID = (int)Reader["UserID"];
                        Password = (string)Reader["Passwordhash"];
                        RoleID = (int)Reader["RoleID"];
                        IsActive = (bool)Reader["IsActive"];
                        ImagePath = (string)Reader["ImagePath"];
                        Email = (string)Reader["Email"];
                        Gendor = Convert.ToChar((string)Reader["Gendor"]);
                    }
                }
            }

            return result;
        }

        public static bool Find(ref int UserID, string UserName, string Password, ref int RoleID,
            ref bool IsActive, ref string ImagePath, ref char Gendor , ref string Email)
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
                        Email = (string)Reader["Email"];
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
                string Query = "SELECT * FROM View_Users";

                using (SqlCommand cmd = new SqlCommand(Query , con))
                {
                    con.Open();

                    SqlDataReader Reader = cmd.ExecuteReader();
                      Dt.Load(Reader);
                }
            }

            return Dt;
        }

        public static int AddUser(string Username, string Password, int Role, bool IsActive, string ImagePath,
            char Gendor, string Email
            )
        {
            int result = 0;

            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string Query = @"INSERT INTO Users (Username,Passwordhash,RoleID,IsActive,ImagePath,Gendor,Email)VALUES(@Username,@Password, 
                                @RoleID,@IsActive,@ImagePath,@Gendor,@Email);
                               SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(Query,con))
                {
                    cmd.Parameters.AddWithValue("@Username",Username);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@RoleID", Role);
                    cmd.Parameters.AddWithValue("@IsActive" , IsActive);
                    cmd.Parameters.AddWithValue("@ImagePath",ImagePath);
                    cmd.Parameters.AddWithValue("@Gendor",Gendor);
                    cmd.Parameters.AddWithValue("@Email", Email);

                    con.Open();

                    object Obj = cmd.ExecuteScalar();

                    if (int.TryParse(Obj.ToString(),out int STR))
                    {
                        result = STR;
                    }
                }
            }

            return result;

        }

        public static bool UpdateUser(int UserID , string Username, int Role, bool IsActive, string ImagePath,
    char Gendor, string Email
    )
        {
            bool result = false;

            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string Query = @"UPDATE Users SET Username = @Username , RoleID = @RoleID , IsActive = @IsActive , 
                                    ImagePath = @ImagePath , Gendor = @Gendor , Email = @Email WHERE UserID = @UserID";
                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@RoleID", Role);
                    cmd.Parameters.AddWithValue("@IsActive", IsActive);
                    cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
                    cmd.Parameters.AddWithValue("@Gendor", Gendor);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@UserID", UserID);

                    con.Open();

                    int Num = cmd.ExecuteNonQuery();

                    if (Num > 0)
                        result = true;
                }
            }

            return result;

        }
        public static bool DeleteUser(string Username)
        {
            bool Result = false;

            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string Query = "DELETE FROM Users WHERE Username = @Username";

                using (SqlCommand cmd = new SqlCommand(Query,con))
                {
                    cmd.Parameters.AddWithValue("@Username", Username);

                    con.Open();

                    int Num = cmd.ExecuteNonQuery();

                    if (Num > 0)
                        Result = true;
                }
            }

            return Result; 
        }

        public static bool ActiveOrDeActiveUser(bool IsActive , string Username)
        {
            bool result = false;
            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_ActiveOrDeActiveUser", con))
                {
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Replace 'true' with your actual boolean variable
                    cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = IsActive;

                    con.Open();

                    int Num = cmd.ExecuteNonQuery();

                    if (Num > 0)
                        result = true;
                }
            }

            return result;
        }



    }
}

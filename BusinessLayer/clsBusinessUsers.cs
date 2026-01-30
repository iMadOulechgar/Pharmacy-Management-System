using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsBusinessUsers
    {
        public int? UserID { get; set; }
        public string Username { get; set; }
        public string Passwordhash { get; set;}
        public clsBusinessRoles Roles { get;} 
        public bool? IsActive { get; set; }
        public string ImagePath { get; set; }
        public char? Gendor {  get; set; }


        public clsBusinessUsers()
        {
            this.UserID = null;
            this.Username = "";
            this.Passwordhash = "";
            this.IsActive = null;
            this.ImagePath = "";
            this.Gendor = null;
        }

        public static bool CheckLogin(string UserName , string Password , ref bool Isactive)
        {
            return clsDataAccessUsers.LoginUser(UserName , Password , ref Isactive);
        }




    }
}

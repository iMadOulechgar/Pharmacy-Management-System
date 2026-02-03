using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
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
        public int? RoleID { get; set; }
        public clsBusinessRoles CompositionRoles { get;}
        public bool? IsActive { get; set; }
        public string ImagePath { get; set; }
        public char? Gendor {  get; set; }
        public string Email {  get; set; } 


        public clsBusinessUsers()
        {
            this.UserID = null;
            this.Username = "";
            this.Passwordhash = "";
            this.RoleID = null;
            this.IsActive = null;
            this.ImagePath = "";
            this.Gendor = null;
            this.Email = "";
        }

        public clsBusinessUsers(int UserID,string UserName,string Password,int RoleID,bool IsActive,string ImagePath,char Gendor,string email)
        {
            this.UserID = UserID;
            this.Username = UserName;
            this.Passwordhash = Password;
            this.RoleID = RoleID;
            this.CompositionRoles = clsBusinessRoles.FindRoleByID(RoleID);
            this.IsActive = IsActive;
            this.ImagePath = ImagePath;
            this.Gendor = Gendor;
            this.Email = email;
        }

        public static clsBusinessUsers FindUserByUsername(string UserName)
        {
            string Password = "", ImagePath = "", Email = "";
            int RoleID = -1 , UserID = -1;
            bool IsActive = false;
            char Gendor = 'm';

            if (clsDataAccessUsers.Find(ref UserID, UserName, ref Password, ref RoleID, ref IsActive, ref ImagePath, ref Gendor, ref Email))
                return new clsBusinessUsers(UserID, UserName, Password, RoleID, IsActive, ImagePath, Gendor, Email);
            else
                return null;
        }

        public static clsBusinessUsers FindUserById(int UserID)
        {
            string UserName = "", Password = "", ImagePath = "" , Email = "";
            int RoleID = -1;
            bool IsActive = false;
            char Gendor = 'm';

            if (clsDataAccessUsers.Find(UserID, ref UserName, ref Password, ref RoleID, ref IsActive, ref ImagePath, ref Gendor , ref Email))
                return new clsBusinessUsers(UserID, UserName, Password, RoleID, IsActive, ImagePath, Gendor , Email);
            else
                return null;
        }

        public static clsBusinessUsers FindUserByUsernameAndPassword(string UserName , string Password , ref bool IsActive)
        {
            string ImagePath = "" , Email = "";
            int RoleID = -1 , UserID = -1;
            char Gendor = 'm';

            if (clsDataAccessUsers.Find(ref UserID,  UserName, Password, ref RoleID, ref IsActive, ref ImagePath, ref Gendor,ref Email))
                return new clsBusinessUsers(UserID, UserName, Password, RoleID, IsActive, ImagePath, Gendor, Email);
            else
                return null;
        }

        public static bool CheckLogin(string UserName , string Password , ref bool Isactive)
        {
            return clsDataAccessUsers.LoginUser(UserName , Password , ref Isactive);
        }

        public static DataTable GetUsers()
        {
            return clsDataAccessUsers.GetAllUsers();
        }


    }
}

using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsBusinessUsers
    {
        public enum enMode { Add =  0, Update = 1 }
        public enMode Mode = enMode.Add;

        public int UserID { get; set; }
        public string Username { get; set; }
        public string Passwordhash { get; set;}
        public int RoleID { get; set; }
        public clsBusinessRoles CompositionRoles { get;}
        public bool IsActive { get; set; }
        public string ImagePath { get; set; }
        public char Gendor {  get; set; }
        public string Email {  get; set; } 


        public clsBusinessUsers()
        {
            this.UserID = -1;
            this.Username = "";
            this.Passwordhash = "";
            this.RoleID = -1;
            this.IsActive = false;
            this.ImagePath = "";
            this.Gendor = 'M';
            this.Email = "";
            Mode = enMode.Add;
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
            Mode = enMode.Update;
        }

        private bool _AddUser()
        {
            if (clsDataAccessUsers.AddUser(this.Username, this.Passwordhash, this.RoleID, this.IsActive, this.ImagePath, this.Gendor, this.Email) > 0)
                return true;

            return false;
        }

        private bool _UpdateUser()
        {
            if (clsDataAccessUsers.UpdateUser(this.UserID, this.Username, this.RoleID, this.IsActive, this.ImagePath, this.Gendor, this.Email))
                return true;

            return false;
        }

        public static bool DeleteUserByUserID(string Username)
        {
            return clsDataAccessUsers.DeleteUser(Username);
        }

        public static bool SwitchFromActiveToInactiver(bool IsActive, string Username)
        {
            return clsDataAccessUsers.ActiveOrDeActiveUser(IsActive, Username);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if (_AddUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    break;
                case enMode.Update:
                    if (_UpdateUser())
                    {
                        return true;
                    }
                    break;
            }

            return false;
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

        public static string GetUserNameByID(int UserId)
        {
            return clsDataAccessUsers.GetUsernameByID(UserId);
        }

    }
}

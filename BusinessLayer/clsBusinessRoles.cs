using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsBusinessRoles
    {
        public int? RoleID { get; set; }
        public string RoleName { get; set; }

        clsBusinessRoles(int roleid , string rolename)
        {
            this.RoleID = roleid;   
            this.RoleName = rolename;
        }

        clsBusinessRoles()
        {
            this.RoleID = null;
            this.RoleName = "";
        }

        public static clsBusinessRoles FindRoleByID(int RoleID)
        {
            string RoleName = "";

            if (clsDataAccessRoles.FindRoles(RoleID,ref RoleName))
                return new clsBusinessRoles(RoleID, RoleName);
            else
                return null;
        }

        public static string GetRoleNameByID(int? ID)
        {
            return clsDataAccessRoles.GetRoleName(ID);
        }

    }
}

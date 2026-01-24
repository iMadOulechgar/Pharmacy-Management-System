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
        public static string GetRoleNameByID(int ID)
        {
            return clsDataAccessRoles.GetRoleName(ID);
        }
    }
}

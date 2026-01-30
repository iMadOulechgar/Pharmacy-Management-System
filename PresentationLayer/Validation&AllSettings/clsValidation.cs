using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System.Validation_AllSettings
{
    public static class clsValidation
    {
        public static bool CheckByInputIsNumber(char c)
        {
            if(!char.IsDigit(c))
                return false;

            return true;   
        }

        public static bool CheckStringIsNumber(string Input)
        {
            foreach(char c in Input)
            {
                if(!char.IsDigit(c))
                    return false;
            }

            return true;
        }




    }
}

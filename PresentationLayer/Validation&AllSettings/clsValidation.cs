using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pharmacy_Management_System.Validation_AllSettings
{
    public static class clsValidation
    {
        public static bool IsNumber(char c)
        {
            if(!char.IsDigit(c))
                return false;

            return true;   
        }
        
        public static bool IsNumber(string Input)
        {
            foreach (char c in Input)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }

        public static bool CheckStringIsNumber(string input)
        {
            return double.TryParse(input, out _);
        }

        public static bool ValidateEmail(string emailAddress)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(emailAddress);
        }



    }
}

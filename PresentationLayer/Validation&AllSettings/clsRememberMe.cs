using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pharmacy_Management_System.Validation_AllSettings
{
    public static class clsRememberMe
    {
        public static bool RememberUsernameAndPassword(string Username, string Password)
        {
            string PathKey = @"HKEY_CURRENT_USER\Software\PMS";

            try
            {
                Registry.SetValue(PathKey, "UserName", Username, RegistryValueKind.String);
                Registry.SetValue(PathKey, "Password", Password, RegistryValueKind.String);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            string PathKey = @"HKEY_CURRENT_USER\Software\PMS";

            try
            {
                Username = Registry.GetValue(PathKey, "UserName", null) as string;
                Password = Registry.GetValue(PathKey, "Password", null) as string;

                if (Password != null && Username != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }

        public static bool CheckIsAlreadyInRegistry(string Username , string Password)
        {
            string PathKey = @"HKEY_CURRENT_USER\Software\PMS";

            string _Username = "", _Password = "";

            try
            {
                _Username = Registry.GetValue(PathKey, "UserName", null) as string;
                _Password = Registry.GetValue(PathKey, "Password", null) as string;

                if (Password == _Password && Username == _Username)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }

    }
}

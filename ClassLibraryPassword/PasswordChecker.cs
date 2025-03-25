using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryPassword
{
    public class PasswordChecker
    {
        public static bool ValidatePassword(string password)
        {
            if (password.Length < 8 || password.Length > 20) return false;

            if (!Regex.IsMatch(password, @"\d")) return false;

            if (!Regex.IsMatch(password, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]")) return false;

            if (!Regex.IsMatch(password, @"[a-z]")) return false;

            if (!Regex.IsMatch(password, @"[A-Z]")) return false;

            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace YumYard.DatabaseAccess
{
    static class Validation
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                // Additional check to ensure the email has a valid domain
                string[] parts = email.Split('@');
                if (parts.Length == 2 && parts[1].Contains("."))
                {
                    return addr.Address == email;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidPassword(string password)
        {
            if (password.Length < 8)
                return false;

            bool hasLetter = false;
            bool hasDigit = false;
            bool hasSpecialChar = false;

            foreach (char c in password)
            {
                if (char.IsLetter(c))
                    hasLetter = true;
                else if (char.IsDigit(c))
                    hasDigit = true;
                else if (!char.IsLetterOrDigit(c))
                    hasSpecialChar = true;

                if (hasLetter && hasDigit && hasSpecialChar)
                    return true;
            }

            return false;
        }
    }
}

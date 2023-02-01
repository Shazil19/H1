using System;
using System.Text.RegularExpressions;

namespace PasswordStrengthChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a password: \n");

            Console.WriteLine
                ("but here are few things you have to make sure about your password: " +
                 "1.\tPassword must be minimum 12 characters and max.  64" +
                 "2.\tThere must be a mix of both UPPER and lowercase" +
                 "3.\tThere must be a mix of characters and numbers" +
                 "4.\tAnd there must be at least one special character\n");

            Console.Write("Please type your Password");

            string password = Console.ReadLine();

            string result = CheckPasswordStrength(password);
            Console.WriteLine(result);
        }

        static string CheckPasswordStrength(string password)
        {
            if (password.Length < 12 || password.Length > 64)
                return "Red: The password must be between 12 and 64 characters.";

            bool hasUpper = false, hasLower = false, hasDigit = false, hasSpecial = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    hasUpper = true;
                else if (char.IsLower(c))
                    hasLower = true;
                else if (char.IsDigit(c))
                    hasDigit = true;
                else if (!char.IsWhiteSpace(c))
                    hasSpecial = true;
            }

            if (!hasUpper || !hasLower || !hasDigit || !hasSpecial)
                return "Red: The password must contain a mix of upper and lowercase letters, digits, and special characters.";

            if (IsSequence(password) || IsRepeat(password))
                return "Yellow: The password is considered weak.";

            return "Green: The password is strong.";
        }

        static bool IsSequence(string password)
        {
            string pattern = @"(\d{4,})|([a-zA-Z]{4,})";
            return Regex.IsMatch(password, pattern);
        }

        static bool IsRepeat(string password)
        {
            string pattern = @"(\d)\1{3,}|([a-zA-Z])\1{3,}";
            return Regex.IsMatch(password, pattern);
        }
    }
}
using System;
using System.Linq;

namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Enter password: ");
                string password = Console.ReadLine();

                string feedback = CheckPassword(password);
                Console.WriteLine(feedback);

                if (feedback == "Green: The password is OK")
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    break;
                }

                else if (feedback == "Yellow: The password is OK but considered weak")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("Do you want to try again? (y/n)");
                    string response = Console.ReadLine();
                    if (response == "n")
                    {
                        break;
                    }
                }

                else if (feedback == "Red: The password is not strong enough")
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Password does not meet the requirements, try again.");
                }
            }
        }

        public static string CheckPassword(string password)
        {
            int minLength = 12;
            int maxLength = 64;
            int length = password.Length;
            if (length < minLength)
            {
                return "Red: The password is not strong enough";
            }
            else if (length > maxLength)
            {
                return "Red: The password is way too strong ";
            }

            bool hasUppercase = false;
            bool hasLowercase = false;
            bool hasNumber = false;
            bool hasSpecial = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUppercase = true;
                }
                else if (char.IsLower(c))
                {
                    hasLowercase = true;
                }
                else if (char.IsDigit(c))
                {
                    hasNumber = true;
                }
                else
                {
                    hasSpecial = true;
                }
            }

            if (!hasUppercase || !hasLowercase || !hasNumber || !hasSpecial)
            {
                return "Red: The password is not strong enough";
            }

            bool isWeak = false;
            for (int i = 0; i < length - 3; i++)
            {
                string sub = password.Substring(i, 4);
                if (sub.All(c => char.IsLetter(c)) || sub.All(c => char.IsDigit(c)))
                {
                    isWeak = false;
                }

                if (sub == "1234" || sub == "2345" || sub == "3456")
                {
                    isWeak = true;
                }

            }

            if (isWeak)
            {
                return "Yellow: The password is OK but considered weak";
            }

            else
            {
                return "Green: The password is OK";
            }
        }
    }
}
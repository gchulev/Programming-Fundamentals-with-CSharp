using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();

            if (ValidateLettersAndDigits(password) && ValidateNumberOfDigits(password) && ValidatePasswordLength(password))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!ValidatePasswordLength(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");//2
                }
                if (!ValidateLettersAndDigits(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");//1
                }
                if (!ValidateNumberOfDigits(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");//3
                }
            }
        }
        public static bool ValidatePasswordLength(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ValidateLettersAndDigits(string password)
        {
            bool hasLettersAndDigits = true;

            foreach (char chr in password)
            {
                if (!char.IsLetterOrDigit(chr))
                {
                    hasLettersAndDigits = false;
                    break;
                }
            }
            return hasLettersAndDigits;
        }
        public static bool ValidateNumberOfDigits(string password)
        {
            bool hasTwoDigits = false;
            int counter = 0;

            foreach (char chr in password)
            {
                if (char.IsDigit(chr))
                {
                    counter++;

                    if (counter == 2)
                    {
                        hasTwoDigits = true;
                        break;
                    }
                }
            }
            return hasTwoDigits;
        }
    }
}

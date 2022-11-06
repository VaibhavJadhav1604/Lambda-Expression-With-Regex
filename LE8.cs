using System;
using System.Text.RegularExpressions;

namespace LE8_Password_1SpecialChar
{
    public class Password_1SpecialChar
    {
        //pattern needed for string
        public string reg = "(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*]).{8,}";
        //comparing both values using regex
        public bool Password_1SpecialCharValidate(string Password_1SpecialChar) => Regex.IsMatch(Password_1SpecialChar, reg) ? true : false;
    }
    internal class LE8
    {
        static void Main(string[] args)
        {
            Password_1SpecialChar p = new Password_1SpecialChar();
            //accepting user input
            Console.Write("Enter Password:");
            string Password_1SpecialChar = Console.ReadLine();
            bool result = p.Password_1SpecialCharValidate(Password_1SpecialChar);
            if (result)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Not Valid");
            }
        }
    }
}

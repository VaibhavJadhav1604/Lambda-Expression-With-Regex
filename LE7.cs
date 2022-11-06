using System;
using System.Text.RegularExpressions;

namespace LE7_Password_1Number
{
    public class Password_1Number
    {
        //pattern needed for string
        public string reg = "(?=.*[A-Z])(?=.*[0-9]).{8}";
        //comparing both values using regex
        public bool Password_1NumberValidate(string Password_1Number) => Regex.IsMatch(Password_1Number, reg) ? true : false;
    }
    internal class LE7
    {
        static void Main(string[] args)
        {
            Password_1Number p = new Password_1Number();
            //accepting user input
            Console.Write("Enter Password:");
            string Password_1Number = Console.ReadLine();
            bool result = p.Password_1NumberValidate(Password_1Number);
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

using System;
using System.Text.RegularExpressions;

namespace LE6_Password_1Upper
{
    public class Password_1Upper
    {
        //pattern needed for string
        public string reg = "[A-Z]{1,}[A-z0-9]{7,}";
        //comparing both values using regex
        public bool Password_1UpperValidate(string Password_1Upper) => Regex.IsMatch(Password_1Upper, reg) ? true : false;
    }
    internal class LE6
    {
        static void Main(string[] args)
        {
            Password_1Upper p = new Password_1Upper();
            //accepting user input
            Console.Write("Enter Password:");
            string Password_1Upper = Console.ReadLine();
            bool result = p.Password_1UpperValidate(Password_1Upper);
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

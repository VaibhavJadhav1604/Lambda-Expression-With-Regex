using System;
using System.Text.RegularExpressions;

namespace LE5_Password
{
    public class Password
    {
        //pattern needed for string
        public string reg = "[A-Za-z0-9]{8,}";
        //comparing both values using regex
        public bool PasswordValidate(string password) => Regex.IsMatch(password, reg) ? true : false;
    }
    internal class LE5
    {
        static void Main(string[] args)
        {
            Password p = new Password();
            //accepting user input
            Console.Write("Enter Password:");
            string password = Console.ReadLine();
            bool result = p.PasswordValidate(password);
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

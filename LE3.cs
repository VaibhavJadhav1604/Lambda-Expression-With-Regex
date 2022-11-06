using System;
using System.Text.RegularExpressions;

namespace LE3_Email
{
    public class Email
    {
        //pattern needed for string
        public string reg = "^[a-z0-9]{3,}@[a-z]{5,}[.][a-z]{2,5}";
        //comparing both values using regex
        public bool EmailValidate(string email) => Regex.IsMatch(email, reg) ? true : false;
    }
    internal class LE3
    {
        static void Main(string[] args)
        {
            Email e = new Email();
            //accepting user input
            Console.Write("Enter Email:");
            string email = Console.ReadLine();
            bool result = e.EmailValidate(email);
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

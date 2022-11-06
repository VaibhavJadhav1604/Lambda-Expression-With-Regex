using System;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace LE1_FirstName
{
    public class FirstName
    {
        //pattern needed for string
        public string reg = "^[A-Z][A-za-z]{2,}";
        //comparing both values using regex
        public bool FirstNameValidate(string firstname) => Regex.IsMatch(firstname,reg) ? true: false;
    }
    internal class LE1
    {
        static void Main(string[] args)
        {
            FirstName fn=new FirstName();
            //accepting user input
            Console.Write("Enter The First Name:");
            string fname=Console.ReadLine();
            bool result = fn.FirstNameValidate(fname);
            if(result)
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

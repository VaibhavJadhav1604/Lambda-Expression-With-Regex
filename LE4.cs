using System;
using System.Text.RegularExpressions;

namespace LE4_MobileNumber
{
    public class MobileNumber
    {
        //pattern needed for string
        public string reg = "[1-9]{2,4}[\\s][0-9]{10}";
        //comparing both values using regex
        public bool MobileNumberValidate(string mobnum) => Regex.IsMatch(mobnum, reg) ? true : false;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MobileNumber mn=new MobileNumber();
            //accepting user input
            Console.Write("Enter Mobile Number:");
            string mobnum=Console.ReadLine();
            bool result=mn.MobileNumberValidate(mobnum);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StringFuncEx
    {
        public static void Main()
        {
            string FirstName = " Sudhakar Sharma ";
            string LastName = "Sudhakar, Sharma";
            Console.WriteLine(FirstName.Length);
            Console.WriteLine(FirstName.CompareTo(LastName));

            Console.WriteLine(FirstName.Contains("p"));
            Console.WriteLine(LastName.StartsWith("S"));
            Console.WriteLine(LastName.EndsWith("a"));

            Console.WriteLine(FirstName.Equals(LastName));
            Console.WriteLine(FirstName.GetType());
            Console.WriteLine(FirstName.IndexOf("h"));
            Console.WriteLine(FirstName.LastIndexOf("S"));
            Console.WriteLine(FirstName.ToLower());
            Console.WriteLine(FirstName.ToUpper());
            Console.WriteLine(LastName.Remove(5));
            Console.WriteLine(LastName.Replace("Sharma","Varma"));
            string[] Name = LastName.Split(',');
            Console.WriteLine(Name[0]);
            Console.WriteLine(LastName.Substring(2, 5));
            Console.WriteLine(LastName.ToCharArray());
            Console.WriteLine(FirstName.Trim());


        }
    }
}

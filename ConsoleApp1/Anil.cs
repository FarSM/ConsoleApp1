using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Anil
    {
        public static void Main()
        {

            List<string> names = new List<string>();
            names.Add("Naveen");
            names.Add("Vinod");
            names.Add("Deepa");

            Action(names);
            Console.WriteLine(names);

            //foreach (string i in names)
            //{
            //    Console.WriteLine(i);
            //}
                
        }


        public static void Action(List<string> names)
        {
            names.Remove("Deepa");
        }
    }
}

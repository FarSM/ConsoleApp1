using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Fibanacci
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number of Fibanacci numbers:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe first {0} Fibanacci numbers are:",n);

            int Fn = 0;
            int F1 = 1;
            int F2 = 1;

            Console.WriteLine(F1 + "\n" + F2);
            for (int i = 1; i < n-1; i++)
            {
                Fn = F1 + F2;
                Console.WriteLine(Fn);
                F1 = F2;
                F2 = Fn;
            }
            Console.ReadLine();
        }

    }
}

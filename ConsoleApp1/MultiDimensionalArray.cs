using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MultiDimensionalArray
    {
        public static void Main()
        {

            int[,] a = new int[2, 3] { { 1, 2, 3 }, { 3, 4, 5 } };
            Console.WriteLine(a[0,2]);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("  " + a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Length of the array is: " +a.Length);
        }
    }
}

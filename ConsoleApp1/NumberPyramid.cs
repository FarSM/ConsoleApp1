using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NumberPyramid
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int num = 1;
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j<= i; j++)
                {
                   
                    Console.Write(" " +num);
                    num++;
                    if(num > n) { break; }
                }
                Console.WriteLine();
                if (num > n) { break; }
            }
        }
    }
        
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NumbersTable
    {
        public static void Main()
        {
            Console.Write("Enter a no: ");
            int n =Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine();

            //int num = 1;
            //for(int i = 1; i <= n; i++)
            //{
            //    int num = i;
            //    for (int j = n; j > i; j--)
            //    {
                    
            //        Console.Write(" {0}", num);
            //        num++;

            //    }
                
            //    for (int j = 0; j < i; j++)
            //    {
                    
            //        Console.Write(" {0}", num);
            //        num--;
            //    }

            //    Console.WriteLine();
            //}

            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < n; j++)
                {

                    int num = i + j + 1;
                    if(num> n)
                    {
                        num = 2 * n - num;
                    }
                    Console.Write(" {0}", num);
                    
                    
                }

                Console.WriteLine();
            }


        }
    }
}

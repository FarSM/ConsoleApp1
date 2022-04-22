using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LinqEx
    {
        public static void Main()
        {
            int[] id = new int[4] { 1, 3, 2 , 4 };
            var ids = from s in id
                      where s > 1 && s < 4
                      orderby s descending
                      select s;

            foreach (int i in ids)
            {
                Console.WriteLine(i);

            }



            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Eid {0}", id[i]);
            //}

            Console.ReadLine();

        }

    }
}
   
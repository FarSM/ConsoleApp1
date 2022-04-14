using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StarPatterns
    {
        public static void Main(string[] Args)
        {
            Console.WriteLine("Enter the no of lines you want in the star pyramid ");
            int no = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < no; i++)
            {
                for (int j = no; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("\n");

            }
            Console.ReadLine();

            for (int i = 0; i <= no; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = no; k > i; k--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("\n");

            }

            Console.ReadLine();

            for (int i = 0; i < no; i++)
            {
                for (int j = no; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine("\n");

            }

            for (int i = 1; i < no; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = no; k > i; k--)
                {
                    Console.Write("{0} ", no - (i + 1));
                }
                Console.WriteLine("\n");

            }

            Console.ReadLine();

        }
    }
}

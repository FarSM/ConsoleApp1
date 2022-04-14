using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Stars
    {
         public static void Main()
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3 - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < i * 2 + 1; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < 3 + 2 - 2 * i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3 - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < i * 2 + 1; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }


                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j <= i + 1; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < 3 - (2 * i); k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }


                Console.ReadLine();

            }

        }
    }

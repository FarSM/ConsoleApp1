using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class WhileDoWhile
    {
        static void Main(string[] args)
        {
            char ch = 'Y';
            while (ch == 'Y')
            {
                Console.WriteLine("Hola_WhileLoop");
                Console.WriteLine("Enter 'Y' or 'N'");
                ch = Convert.ToChar(Console.ReadLine());
            }
            Console.ReadLine();

            int i = 22;
            do
            {
                Console.WriteLine("HOLA_DoWhileloop");
                i++;
            }
            while (i < 10);//22<10

            Console.ReadLine();
        }

    }
}

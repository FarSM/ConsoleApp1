using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Parameters
    {
        public void EvenOddNumbers(int num1, int num2)
        {
            Console.WriteLine("\nEven numbers in between the 2 given numbers are : ");
            for (int i = num1+1; i < num2; i++)
            {
                if (i%2 == 0)
                {
                    Console.Write("  " +i);
                }
            }
            Console.WriteLine("\n \nOdd numbers in between the 2 given numbers are : ");
            for (int i = num1+1; i < num2; i++)
                if (i % 2 == 1)
                {
                Console.Write("  " +i);
                }
        }

        public string EvenOrOdd( int num)
        {
            if (num % 2 == 0)
            {
                return "The given number is even";
            }
            else
                return "The given number is odd";
        }

        public static void Main()
        {
            Parameters obj = new Parameters();

            Console.Write("Enter a number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a bigger number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            obj.EvenOddNumbers(n1, n2);

            Console.Write("\n \nEnter any number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(obj.EvenOrOdd(23));

        }
    }
}

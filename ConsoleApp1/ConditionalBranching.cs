using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ConditionalBranching
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Election");
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age <= 17)
            {
                Console.WriteLine("You are not eligible to vote");
            }
            else
            {
                Console.WriteLine("Please cast your vote");
            }
        }
    }
}

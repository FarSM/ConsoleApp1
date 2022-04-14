using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StuArray
    {
        public static void Main()
        {



            int[] StuID = new int[3];
            string[] StuName = new string[3];
            int[] StuMarks = new int[3];

            Console.WriteLine("Enter 3 Student Details\n");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\nEnter Student ID: ");
                StuID[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Student name: ");
                StuName[i] = Console.ReadLine();
                Console.Write("Enter Student Marks: ");
                StuMarks[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("\nStudent Details");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("ID: " + StuID[i]);
                Console.Write("   Name: " + StuName[i]);
                Console.WriteLine("      Marks: " + StuMarks[i]);

           
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Test15th
    {
        public static void Main()
        {

            //    for(int i = 0; i < 10; i++)
            //    {
            //        Console.Write("Enter Employee Name:  ");
            //        string EmpName = Console.ReadLine();
            //        Console.Write("Enter Employee ID:  ");
            //        int empID = Convert.ToInt32(Console.ReadLine());

            //        while (EmpName != "yes")
            //        {

            //            Console.WriteLine("Employee ID is {0} and Employee name is {1}", EmpName, empID);
            //            break;
            //        }

            //    }
            //    Console.WriteLine("No details entered");

            string confirmation = "yes";
            while (confirmation == "yes")
            {
                Console.Write("Enter Employee Name:  ");
                string EmpName = Console.ReadLine();
                Console.Write("Enter Employee ID:  ");
                int empID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Employee ID is {0} and Employee name is {1}", EmpName, empID);
                Console.Write("\n Enter next Employee deatail?  ");
                string loopconfirmation = Console.ReadLine();
                confirmation = loopconfirmation;

            }

            //TABLES
            //Console.Write("Enter the no of tables:  ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1;i<= 10; i++)
            //{
            //    //Console.WriteLine("\n  Table of " + i);
            //    for (int j = 2; j <= num ; j++)
            //    {
            //        Console.Write(" {0} x {1} = {2}    ", j, i, (i * j));
            //    }
            //    Console.WriteLine();
            //}

            //INVERSE COLOURS
            //for (int i = 1; i <= 5; i++)
            //Console.Write("Enter a colour:  ");
            //string c1 = Console.ReadLine();
            //Console.Write("Enter a colour:  ");
            //string c2 = Console.ReadLine();
            //Console.Write("Enter a colour:  ");
            //string c3 = Console.ReadLine();
            //Console.Write("Enter a colour:  ");
            //string c4 = Console.ReadLine();
            //Console.Write("Enter a colour:  ");
            //string c5 = Console.ReadLine();


            //{
            //    Console.Write("Enter a colour:  ");
            //    string i = Console.ReadLine();

            //}


        }
    }
}

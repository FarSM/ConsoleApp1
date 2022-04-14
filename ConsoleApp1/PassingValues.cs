using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PassingValues
    {
        public static void Main()
        {
            int EmpID = 121;
            string EmpName = "sha";
            //float EmpSalary = 276.236144369F;
            //double EmpSalary = 276.236144369;
            decimal EmpSalary = 276.2361443696633959853664346866M;
            char EmpStatus = 'A';



            Console.WriteLine("Employee ID : " + EmpID);
            Console.WriteLine("Employee Name : " + EmpName);
            Console.WriteLine("Employee Salary : " + EmpSalary);
            Console.WriteLine("Employee Status : " + EmpStatus);

            Console.ReadLine();
        }
    }


    //PASSING DYNAMIC VALUES
    internal class PassingDynamicValues
    {
        public static void Main()
        {
            Console.WriteLine("Enter Employee ID : ");
            int EmpID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name : ");
            string EmpName = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary : ");
            float EmpSalary = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Employee Status : ");
            int EmpStatus = Convert.ToChar(Console.ReadLine());

            //Console.WriteLine("Employee ID : " + EmpID);
            //Console.WriteLine("Employee Name : " + EmpName);
            //Console.WriteLine("Employee Salary : " + EmpSalary);
            //Console.WriteLine("Employee Status : " + EmpStatus);
            Console.WriteLine(" Employee ID : " + EmpID + "\n Employee Name: " + EmpName + "\n Employee Salary : " + EmpSalary + "\n Employee Status: " + EmpStatus);
            Console.ReadLine();
        }
    }
}

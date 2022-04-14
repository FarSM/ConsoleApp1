using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee_MethodOverloading
    {
        public int EmpID()
        {
            Console.Write("Enter Employee ID:  ");
            int empID = Convert.ToInt32(Console.ReadLine());
            return empID;
        }
        public string EmpName()
        {
            Console.Write("Enter Employee Name:  ");
            string EmpName = Console.ReadLine();
            return EmpName;

        }
        public void EmployeeDetail()
        {
            Employee_MethodOverloading obj = new Employee_MethodOverloading();
            int empID = obj.EmpID();
            string empName = obj.EmpName();
            Console.WriteLine("Employee ID is {0} and Employee name is {1}",empName,empID);

        }
        public static void Main()
        {
            Employee_MethodOverloading obj = new Employee_MethodOverloading();
            obj.EmployeeDetail();
        }
    }
}

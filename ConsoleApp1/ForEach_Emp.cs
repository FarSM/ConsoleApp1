using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ForEach_Emp
    {
        public static void Main()
        {
            EmployeeClass obj1 = new EmployeeClass();
            obj1.EmpID = 121;
            obj1.EmpName = "Sarita";
            EmployeeClass obj2 = new EmployeeClass();
            obj2.EmpID = 122;
            obj2.EmpName = "Sara";
            EmployeeClass obj3 = new EmployeeClass();
            obj3.EmpID = 123;
            obj3.EmpName = "Sia";

            List<EmployeeClass> EmployeeList = new List<EmployeeClass>();

            EmployeeList.Add(obj1);
            EmployeeList.Add(obj2);
            EmployeeList.Add(obj3);

            foreach(EmployeeClass e in EmployeeList)
            {
                Console.WriteLine(e.EmpID + " : "+ e.EmpName);
            }
             Console.ReadLine();
        }
    }
}

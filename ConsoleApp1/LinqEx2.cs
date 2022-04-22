using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LinqEx2
    {
        public static void Main()
        {
            EmpModel emp1 = new EmpModel();
            emp1.EmpID = 121;
            emp1.EmpName = "Sarita";
            emp1.EmpSalary = 1000;

            EmpModel emp2 = new EmpModel();
            emp2.EmpID = 122;
            emp2.EmpName = "Farheen";
            emp2.EmpSalary = 3000;

            EmpModel emp3 = new EmpModel();
            emp3.EmpID = 123;
            emp3.EmpName = "Sudhakar";
            emp3.EmpSalary = 2000;

            List<EmpModel> list = new List<EmpModel>();
            list.Add(emp1);
            list.Add(emp2);
            list.Add(emp3);

            //var emp = from e in list
            //          where e.EmpSalary > 1000
            //          select e;

            //var emp = from e in list
            //          where e.EmpName.Contains("S")
            //          select e;

            //var emp = list.Count();
            //Console.Write(emp);

            var emp = list.Where(x => x.EmpID > 1).ToList(); 

            foreach (var item in emp)
            {
                Console.WriteLine(item.EmpName+ "," + item.EmpID );
            }


        }
    }

    public class EmpModel
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }

    }
}

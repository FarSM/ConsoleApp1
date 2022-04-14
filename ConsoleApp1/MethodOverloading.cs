using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MethodOverloading
    {
        public void getName1()
        {
            Console.WriteLine("Hello1");

        }
        public void getName2()
        {
            Console.WriteLine("Hello2");

        }
        public string getName3()
        {
            Console.WriteLine("Hello3");
            return "Anil";

        }
    }

    internal class MethodOverloading2
    {
        public static void Main()
        {
            MethodOverloading obj = new MethodOverloading();
            obj.getName1();
            obj.getName2();
            string StudentName = obj.getName3();
            Console.WriteLine(StudentName);
            

        }
        //public static void Main()
        //{
        //    MethodOverloading obj = new MethodOverloading();    
        //    obj.getName1();
        //    obj.getName2();
        //    string StudentName = obj.getName3();
        //    Console.WriteLine(StudentName);
        //}
    }
}

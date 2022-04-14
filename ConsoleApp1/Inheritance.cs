using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Inheritance1
    {
        public Inheritance1() { //Constructor created
       
            Console.WriteLine("Inheritance1 constructor is called");
        }
        public void Display()
        {
            Console.WriteLine("Inheritance 1 is called");
        }
    }
    internal class Inheritance2: Inheritance1
    {
        public Inheritance2()
        {

            Console.WriteLine("Inheritance2 constructor is called");
        }
        public void Display()
         
        {
            base.Display(); // base keyword indicates parent class
            Console.WriteLine("Inheritance 2 is called");
        }
    }
    internal class Inheritance3: Inheritance2
    {
        public Inheritance3()
        {

            Console.WriteLine("Inheritance3 constructor is called");
        }
        public void Display()
        {
            Console.WriteLine("Inheritance 3 is called");
        }
    }
    internal class Inheritance
    {
        public static void Main()
        {
            Inheritance2 obj = new Inheritance3();
            obj.Display();
        }
    }
}

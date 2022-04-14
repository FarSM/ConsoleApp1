using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Overriding1
    {
        public virtual void Display()
        {
            Console.WriteLine("Class1 method called");
        }
        public virtual void Display2()
        {
            Console.WriteLine("Class1 method2 called");
        }
    }
    class Overriding2: Overriding1
    {
        public override void Display()
        {
            Console.WriteLine("Class2 method called");
        }
        public override void Display2()
        {
            Console.WriteLine("Class2 method2 called");
        }

        public static void Main()
        {
            Overriding1 Ex = new Overriding2();

            Ex.Display();
            Ex.Display2();

        }
    }
   
    }

        
        
    


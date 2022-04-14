using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MethodOverridingEx
    {
        public virtual void Display()
        {
            Console.WriteLine("Parent class display method called");
        }
    }

    class MethodOverridingEx2: MethodOverridingEx
        {
        public override void Display()
        {
            Console.WriteLine("Child class display method called");
        }

        public static void Main()
        {
            MethodOverridingEx2 obj = new MethodOverridingEx2();
            obj.Display();


        }
    }
}

// 'virtual' in parent class and 'override' in child class for Method Overriding
// 'new' in child class for Method Overhiding
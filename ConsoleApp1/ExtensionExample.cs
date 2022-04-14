using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ExtensionExample
    {
        public void A()
        {
            Console.WriteLine("A is called");
        }
        public void B()
        {
            Console.WriteLine("B is called");
        }
    }
    internal class ExtensionExample1
    {
        public void C()
        {
            Console.WriteLine("C is called");

        }

        public static void Main()
        {
            ExtensionExample obj = new ExtensionExample();
            obj.A();
            obj.B();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Polymorphism
    {
        public void Message()
        {
            Console.WriteLine("Hello");
        }
        public void Message(int a)
        {
            Console.WriteLine("Value is "+a);
        }
        public void Message(int a, string b)
        {
            Console.WriteLine("Values are {0} and {1}",a,b);
        }
        public void Message(string a, int b)
        {
            Console.WriteLine("Values are {0} and {1}", a, b);
        }

        public static void Main()
        {
            Polymorphism poly= new Polymorphism(); 
            poly.Message();
            poly.Message(111);
            poly.Message(11, "Hello");
            poly.Message("Hello", 111);

        }
    }
}

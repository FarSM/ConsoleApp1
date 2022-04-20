using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Delegate
    {
        public delegate void AddDel(int a, int b);
        public void Add(int a, int b)
        {
           Console.WriteLine(a+b);
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }



        public static void Main()
        {
            Delegate ObjDel = new Delegate();
            AddDel obj = new AddDel(ObjDel.Add);
           // obj.Invoke(10, 20);
            obj+=ObjDel.Multiply;
            obj.Invoke(10, 20);

        }
    }
}


//A  delegate is an object which refers to method or you can say , It is a referance variable which can hold referance for a method.
//Delegate in C# are similar to Function pointer in C and C++
//We can say that it provides a way to tell which method is to be called when an event is raised.
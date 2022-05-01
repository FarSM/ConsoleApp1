using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MultiThreadingEx
    {

        public static void Method2()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread1:{0}", i);
            }
        }

        public static void Method3()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread2:{0}", i);
            }
        }

        public static void Method1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread3:{0}", i);
            }
        }
        public static void Main()
        {
            Console.WriteLine("Main thread started");
            Thread t1 = new Thread(Method1)
            {
                Name = "Thread1"
            };
            Thread t2 = new Thread(Method2)
            {
                Name = "Thread2"
            };
            Thread t3 = new Thread(Method3)
            {
                Name = "Thread3"
            };
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Main Thread ended");
        }
    }
}

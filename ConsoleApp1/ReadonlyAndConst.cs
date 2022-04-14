using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ReadonlyAndConst
    {
        //const int a =30;


        //public static void Main()
        //{

        //    Console.WriteLine(ReadonlyAndConst.a);
        //}
        readonly int a;

        ReadonlyAndConst() //Initialization using constructor
        {
            a = 12;
        }

        public static void Main()
        {
            ReadonlyAndConst obj = new ReadonlyAndConst();
            Console.WriteLine(obj.a);
        }

    }
}

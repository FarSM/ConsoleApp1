using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class PartialClassEx
    {
            public void Show()
            {
                Console.WriteLine("Show method called");
            }
        
    }
    partial class PartialClassEx
    {
        public void Show1() //Cannothave same method name cause the 2 classes are one and the same
        {
            Console.WriteLine("Show1 method called");
        }

    }

    partial class PartialClassEx
    {
        public static void Main()
        {
            PartialClassEx obj = new PartialClassEx();
            obj.Show();
            obj.Show1();
        }
    }
}

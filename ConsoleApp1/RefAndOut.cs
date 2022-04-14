using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class RefAndOut
    {
        public static int SendData(out int a)
        {

            a = 20;
            a = a + 1;
            return a;
        }

        public static void Main()
        {
            int a = 1;
            int res = SendData(out a); 
            Console.Write(res); 

        }
    }
}

//Call by value. No ref and out used. Performance wise, using ref is better as we send address pointers.
//Using ref we pass the value by referencing to the address. Argument may or maynot be modified by the method
// Using out, the parameter passed MUST be modified by the method
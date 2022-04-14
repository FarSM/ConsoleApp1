using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public sealed class SealedExample
    {
        public void Show()
        {
            Console.WriteLine("Show method called");
        }
    }
    public class SealedExample2 // : SEaledExample Cannot inherit fro sealed class
    {
       
    }
}

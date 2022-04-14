using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StringAndStringBuilder
    {
        public static void Main()
        {
            string a = "Welcome";
            a = "Not Welcome"; // Immutable: New object is created and assigned value
            Console.WriteLine(a);

            StringBuilder sb = new StringBuilder();
            sb.Append("Howdy");
            sb.Replace("dy", " you doing?");
            Console.WriteLine(sb);

            sb.Replace(" you", " are you", 3, 10);
            Console.WriteLine(sb);
        }
    }
}

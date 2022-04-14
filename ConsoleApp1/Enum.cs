using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EnumExample
    {
        enum Print
        {
            Excel,
            PDF,
            Word
        }



        public static void Main()
        {
            Print print = Print.Excel;
            Console.Write("Enter print output: 1 for Excel and 2 for PDF");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (print)
            {
                case Print.Excel:
                    Console.WriteLine(Print.Excel);
                    break;
                case Print.PDF:
                    Console.WriteLine(Print.PDF);
                    break;
                case Print.Word:
                    Console.WriteLine(Print.PDF);
                    break;
                default:
                    Console.WriteLine("No file to print");
                    break;
            }

        }
    }
}

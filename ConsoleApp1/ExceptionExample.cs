using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ExceptionExample
    {
        public static void Main()
        {
            int a = 10;
            try
            {
                int b = Convert.ToInt32(Console.ReadLine());
                int c = a / b;
                Console.WriteLine(c);
            }
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("My Exception: " + ex.Message); 
            //}
            catch (FormatException ex)
            {
                Console.WriteLine("My Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("My Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Resource closed");
            }

            Console.WriteLine("Testing");
        }
    }
}

//public static void Main()
//{
//    int a = 10;
//    try
//    {
//        int b = Convert.ToInt32(Console.ReadLine());
//        int c = a / b;
//        Console.WriteLine(c);
//    }
//    catch
//    {
//        Console.WriteLine("Exception occured");
//    }

//    Console.WriteLine("Testing");
//}

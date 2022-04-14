using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class OOP_MobileTypes
    {
        public class Mobile
        {
            int price; //declaration of variables
            string name; //declaration of variables

            void calling()
            {
                Console.WriteLine("Calling");
            }
            public static void Main() //Entry point for execution
            {
                Mobile Samsung = new Mobile();
                Samsung.name = "Samsung S21FE";
                Samsung.price = 50000;

                Console.WriteLine("Name of Mobile is " + Samsung.name + " and the price is " + Samsung.price);
                Samsung.calling(); //calling methods

                Mobile Nokia = new Mobile();
                Nokia.name = "Nokia 3100";
                Nokia.price = 30000;

                Console.WriteLine("Name of Mobile is " + Nokia.name + " and the price is " + Nokia.price);
                Nokia.calling(); //calling methods
            }
        }
    }
}

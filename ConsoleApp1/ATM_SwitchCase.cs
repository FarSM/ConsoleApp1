using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ATM_SwitchCase
    {
        public static void Main(string[] Args)
        {


            //ATM
            Console.WriteLine("WElcome to our ATM Service");
            Console.WriteLine("**************************");


            Console.WriteLine("Please insert your card \nEnter 'y' or 'n'");
            char card = Convert.ToChar(Console.ReadLine());
            switch (card)
            {
                case 'y':
                    Console.WriteLine("Card inserted. Enter your 6 digit pin no");
                    int pin = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Pin accepted");

                    int bal = 1200000;
                    Console.WriteLine("\nEnter the operation to be conducted: \n 1. Balance enquiry\n 2. Withdraw\n 3. Credit\n 4. Insurance ");
                    int op = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            Console.WriteLine("Your balance is: " + bal);
                            break;
                        case 2:
                            Console.WriteLine("Enter the amount to be withdrawn: ");
                            int amt = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Balance is : " + (bal - amt));
                            break;
                        case 3:
                            Console.WriteLine("Enter the amount to be credited: ");
                            int amt2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Balance is : " + (bal + amt2));
                            break;
                        case 4:
                            Console.WriteLine("Insurance policy present");
                            break;
                        default:
                            Console.WriteLine("No operation entered");
                            break;
                    }
                    Console.ReadLine();
                    break;

                case 'n':
                    Console.WriteLine("Card not inserted");
                    break;
            }
            Console.ReadLine();

        }
    }
}

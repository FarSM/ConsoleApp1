using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SwitchCaseExamples
    {
        public static void Main(string[] Args)
        {
            int a = 10, b = 10, c = 30;

            //If Else If Block
            if (a > b)
            {
                Console.WriteLine("a is greater");
            }
            else if (b > a)
            {
                Console.WriteLine("b is greater");
            }
            else
            {
                Console.WriteLine("Numbers are equal");
            }
            Console.ReadLine();

            //Nested If Block
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("a is greater");
                }
            }
            if (b > a)
            {
                if (b > c)
                {
                    Console.WriteLine("b is greater");
                }
            }
            if (c > a)
            {
                if (c > b)
                {
                    Console.WriteLine("c is greater");
                }
            }
            if (a == b && b == c)
            {
                Console.WriteLine("All numbers are equal");
            }
            Console.ReadLine();

            //Switch Case
            Console.WriteLine("Hotel Fara");
            Console.WriteLine("***********");
            Console.WriteLine("Enter a no for your choice\n 1: Idly \n 2: Dosa \n 3:Puri \n 4:Vada");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Have Idly");
                    break;
                case 2:
                    Console.WriteLine("Have Dosa");
                    break;
                case 3:
                    Console.WriteLine("Have Puri");
                    break;
                case 4:
                    Console.WriteLine("Have Vada");
                    break;
                default:
                    Console.WriteLine("Bill");
                    break;
            }
            Console.ReadLine();

            //Switch Case Example
            Console.WriteLine("Enter an alphabet in lower case");
            Console.WriteLine("*******************************");
            char alph = Convert.ToChar(Console.ReadLine());
            switch (alph)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'u':
                case 'o':
                    Console.WriteLine("Alphabet {0} is a vowel", alph);
                    break;
                default:
                    Console.WriteLine("Alphabet {0} is a consonant", alph);
                    break;
            }
            Console.ReadLine();

            //Switch Case Example 2
            Console.WriteLine("Enter Your shopping choice");
            Console.WriteLine("**************************");
            Console.WriteLine("1: Clothes\n2: Watch");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter your choice of clothing: \n 1: Shirt \n 2: Jeans");
                    int cho = Convert.ToInt32(Console.ReadLine());
                    switch (cho)
                    {
                        case 1:
                            Console.WriteLine("Shirt of price Rs 1000");
                            break;
                        case 2:
                            Console.WriteLine("Jeans of price Rs 1000");
                            break;
                        default:
                            Console.WriteLine("No item is selected");
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("Enter your choice of watch: \n 1: Tissot \n 2: Rado");
                    int cho2 = Convert.ToInt32(Console.ReadLine());
                    switch (cho2)
                    {
                        case 1:
                            Console.WriteLine("Tissot watch  of price Rs 10000");
                            break;
                        case 2:
                            Console.WriteLine("Rado watch of price Rs 100000");
                            break;
                        default:
                            Console.WriteLine("No item is selected");
                            break;
                    }
                    break;
            }

            Console.ReadLine();

            Console.WriteLine("Enter the first no: ");
            int no1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second no: ");
            int no2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operation to be conducted: \n 1. +\n 2. -\n 3. *\n 4./ ");
            char op = Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case '+':
                    Console.WriteLine(no1 + no2);
                    break;
                case '-':
                    Console.WriteLine(no1 - no2);
                    break;
                case '*':
                    Console.WriteLine(no1 * no2);
                    break;
                case '/':
                    Console.WriteLine(no1 / no2);
                    break;
                default:
                    Console.WriteLine("No operation entered");
                    break;
            }
            Console.ReadLine();

        }
    }
}

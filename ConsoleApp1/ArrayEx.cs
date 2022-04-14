using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ArrayEx
    {
        public static void Main()
        {
            //int[] Arr = { 1, 2, 3, 4, 5 ,6 ,7};
            //int[] Arr1 = new int[2];
            //Arr1[0] = 1;
            //Arr1[1] = 2;
            //int[] Arr2 = new int[2] { 3, 4};

            //Console.WriteLine(Arr[2]);
            //Console.WriteLine(Arr1[1]);
            //Console.WriteLine(Arr2[0]);

            int[] StudentID = { 1, 2, 3 };
            foreach(var item in StudentID)
            {
                Console.WriteLine(item);
            }

            int[] StuID2 = new int[3];
            string[] StuName = new string[3];

            Console.WriteLine("Enter 3 employee Details\n");
            for(int i = 0; i < 3; i++)
            {
                Console.Write("Enter Student ID: " );
                StuID2[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Student name: ");
                StuName[i] = Console.ReadLine();

            }
            Console.WriteLine("\nStudent Details");
            for (int i = 0;i < 3; i++)
            {
                Console.Write("ID: "+StuID2[i]);
                Console.WriteLine("   Name: "+StuName[i]);

            }

        }
    }
}

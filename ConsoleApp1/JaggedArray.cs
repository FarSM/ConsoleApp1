using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class JaggedArray
    {
        public static void Main()
        {
            string[][] Qualification = new string[3][];
            Qualification[0] = new string[3] { "SSLC", "PUC", "BSc" };
            Qualification[1] = new string[2] { "BCom", "MBA" };
            Qualification[2] = new string[1] { "MBBS" };

            for (int i = 0; i < Qualification.Length; i++)
            {

                Console.Write("Qualification of the student {0}: ",i+1);
                for (int j = 0; j < Qualification[i].Length; j++)
                
                {
                    Console.Write("   " +Qualification[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}

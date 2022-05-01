using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CopyfromOneFiletoAnother
    {
        public static void Main()
        {
            //    File.Copy(@"D:\C#ClassPracticeFraheen\ConsoleApp1\test1file.txt", @"D:\C#ClassPracticeFraheen\ConsoleApp1\Test2fileCopyDestination2.txt");
            //    Console.WriteLine(File.ReadAllText(@"D:\C#ClassPractSiceFraheen\ConsoleApp1\Test2fileCopyDestination2.txt"));
          
            string Filepath = @"D:\C#Programs\ConsoleApp1\ConsoleApp1\bcd.txt";
            using (StreamWriter sw = File.AppendText(Filepath))
            {
                sw.WriteLine("Anil is coding");

            }
            using (StreamReader sr = File.OpenText(Filepath))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }
    }
}

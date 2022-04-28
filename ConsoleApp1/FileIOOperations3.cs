using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FileIOOperations3
    {
        public static void Main()
        {
            string FilePath;
            Console.WriteLine("Enter the file path:");
            FilePath = Console.ReadLine();

            FileInfo fileInfo = new FileInfo(FilePath);

            if (!fileInfo.Exists)
            {
                StreamReader sr = new StreamReader(FilePath);

                string Content;
                Content = sr.ReadToEnd();
                Console.WriteLine(Content);
                sr.Close();

                //Console.WriteLine("Enter the content?");
                //Content = Console.ReadLine();
                //StreamWriter sw = new StreamWriter(FilePath);
                //sw.WriteLine(Content);
                //sw.Close();
                //Console.WriteLine("Return successfully");

            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
    }
}

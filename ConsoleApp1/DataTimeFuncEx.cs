using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DataTimeFuncEx
    {
        public static void Main()
        {
            DateTime Date1 = new DateTime(2022,04,13);
            Console.WriteLine(Date1);
            DateTime Date2 = new DateTime(2022, 04, 13, 10, 20, 50);
            Console.WriteLine(Date2);
            Console.WriteLine(DateTime.MinValue);
            Console.WriteLine(DateTime.MaxValue);
            DateTime date = DateTime.Now;
            Console.WriteLine(date);
            DateTime Date3 = DateTime.Now.AddDays(30);
            Console.WriteLine(Date3);
            DateTime Date4 = DateTime.Now.AddMonths(2);
            Console.WriteLine(Date4);   
            DateTime Date5 = DateTime.Now.AddYears(2);
            Console.WriteLine(Date5);
            TimeSpan TS = new TimeSpan(30,0,0,0,0);
            DateTime Date6 = DateTime.Now.Add(TS);
            Console.WriteLine(Date6);
            TimeSpan TS1 = new TimeSpan(0, 2, 0, 0, 0);
            DateTime Date7 = DateTime.Now.Add(TS1);
            Console.WriteLine(Date7);
            string DateString = DateTime.Now.ToShortDateString();
            Console.WriteLine( DateString);
            string DateString1 = DateTime.Now.ToLongDateString();
            Console.WriteLine(DateString1);
            DateTime Date8 = DateTime.Parse( DateString1 );
            Console.WriteLine(Date8);

            string TimeL = DateTime.Now.ToLongTimeString();
            string TimeS = DateTime.Now.ToShortTimeString();
            Console.WriteLine(TimeS);
            Console.WriteLine(TimeL);

            DateTime Date9 = new DateTime(2022, 04, 13, 5 , 20, 50);
            DateTime Date10 = new DateTime(2022, 05, 13, 10, 20, 50);
            TimeSpan ts = Date10.Subtract(Date9);
            Console.WriteLine(ts);
            TimeSpan Date11 = Date10 - Date9;
            Console.WriteLine(Date11);
            Console.WriteLine(Date9.Year);
            Console.WriteLine(Date9.Month);
            Console.WriteLine(Date9.Day);
            Console.WriteLine(Date9.Hour);
            Console.WriteLine(Date9.DayOfWeek);
            Console.WriteLine((int)Date9.DayOfWeek);

            DateTime Date12 = DateTime.Now;
            Console.WriteLine(Date12.ToString("MM/dd/yyyy"));
            Console.WriteLine(Date12.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(Date12.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            Console.WriteLine(Date12.ToString("MM/dd/yyyy HH:mm tt"));
            Console.WriteLine(Date12.ToString("MMMM dd "));
            Console.WriteLine(Date12.ToString("yyyy'-'MM'-'dd HH':'mm':'ss"));
            Console.WriteLine(Date12.ToString("h:mm tt"));









        }
    }
}

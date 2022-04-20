using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CustomisedException
    {
        public static void Main()
        {
            ClassTemperature T = new ClassTemperature();
            try
            {
                T.ShowTemp();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        } 
    }

    public class TemperatureException: Exception
    {
        public TemperatureException(string message): base(message)
        {

        }
    }

    class ClassTemperature
    {
        int Temp = 0;
        public void ShowTemp()
        {
            if(Temp == 0)
            {
                throw (new TemperatureException("Temperature Exception occured."));
            }
            else
            {
                throw (new TemperatureException("Temperature Exception not occured."));
                Console.WriteLine(Temp);
            }
        }
    }


}

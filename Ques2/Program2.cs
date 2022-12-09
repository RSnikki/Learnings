using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques2
{
    class Program2
    {
        public double TemperatureConverter(double tempInC)
        {
            double tempInF = (tempInC * 1.8) + 32;
            return tempInF;
        }

        static void Main(String[] args)
        {
            Program2 q2 = new Program2();

            Console.Write("Enter Temperature in Degree Celcius: ");
            double temp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Temperature in Degree Farenheit: {0}", q2.TemperatureConverter(temp));
            Console.ReadLine();
        }
    }
}

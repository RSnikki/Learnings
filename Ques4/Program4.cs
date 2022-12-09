using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques4
{
    class Program4
    {
        public int CalculateNoOfCookiesSold(int flighTookOff, int flightLanded, int tookOffSeatingCapacity, int landedSeatingCapacity)
        {
            int noSoldT = 2 * (flighTookOff * tookOffSeatingCapacity);
            int noSoldL = 2 * (flightLanded * (int)(landedSeatingCapacity / 2));

            int totalSold = noSoldL + noSoldT;

            return totalSold;
        }

        static void Main(string[] args)
        {
            Program4 p1 = new Program4();

            Console.Write("Enter no. of flight took off: ");
            int flightTook = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter no. of flight landed: ");
            int flightLanded = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter capacity of flight that took off: ");
            int capFlightTook = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter capacity of flight landed: ");
            int capFlightLanded = Convert.ToInt32(Console.ReadLine());

            int totalCookiesSold = p1.CalculateNoOfCookiesSold(flightTook, flightLanded, capFlightTook, capFlightLanded);

            Console.WriteLine("Total No. of Cookies Sold: {0}", totalCookiesSold);

            Console.ReadLine();
        }
    }
}

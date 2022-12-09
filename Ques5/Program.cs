using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques5
{
    class Program
    {
        public int CalculateFlightCharge(int noOfAdults, int noOfChildren)
        {
            double totalChargeAdult = 150 * noOfAdults;
            double totalChargeChild = 50 * noOfChildren;
            double totalSerTax = 0.07 * (totalChargeAdult + totalChargeChild);
            double totalTicketCost = totalChargeAdult + totalChargeChild + totalSerTax;

            double totalTicketCostToPay = totalTicketCost - (0.1 * totalTicketCost);

            return Convert.ToInt32(totalTicketCostToPay);
        }
        static void Main(string[] args)
        {
            Program p5 = new Program();

            Console.Write("Enter No. of Adults: ");
            int adultNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter No. of Children: ");
            int childrenNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Total Amount to be Paid for {0} adults and {1} children: {2}", adultNo, childrenNo, p5.CalculateFlightCharge(adultNo, childrenNo));
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDem04
{
    class Program
    {
        static void Main(string[] args)
        {
            Seller sellerOne = new DomesticSeller("S1001", "David", new[] { "Tamilnadu", "Delhi" }, true);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("---------------Delivery Charges-------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("New York: " + sellerOne.CalculateShippingCharges("Tamilnadu"));
            Console.WriteLine("Delhi: " + sellerOne.CalculateShippingCharges("Delhi"));
            Console.WriteLine("Kolkata: " + sellerOne.CalculateShippingCharges("Kolkata"));

            Console.ReadLine();
        }
    }
}

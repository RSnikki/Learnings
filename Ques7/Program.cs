using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques7
{
    class Program
    {
        public int CalculateBillAmount(string foodType, int quantityOrdered, int distanceInKms)
        {
            int foodCharge, deliveryCharge, totalCharge;
            if (quantityOrdered > 0)
            {

                if (foodType.Equals("V"))
                {
                    foodCharge = 3 * quantityOrdered;
                    deliveryCharge = distanceInKms * DeliveryChargePKm(distanceInKms);
                    totalCharge = foodCharge + deliveryCharge;
                    return totalCharge;
                }
                else if (foodType.Equals("N"))
                {
                    foodCharge = 5 * quantityOrdered;
                    deliveryCharge = distanceInKms * DeliveryChargePKm(distanceInKms);
                    totalCharge = foodCharge + deliveryCharge;
                    return totalCharge;
                }
                else
                {
                    return -1;
                }
            }
            return -1;
        }

        public int DeliveryChargePKm(int distance)
        {
            if (distance <= 3)
            {
                return 0;
            }
            else if (distance <= 6)
            {
                return 1;
            }
            else
            {
                return 2;
            }

        }

        static void Main(string[] args)
        {
            Program p7 = new Program();

            Console.Write("Enter Food Type 'V' for Vegetrain food and 'N' for Non-Vegetarian: ");
            string foodType;
            foodType = Console.ReadLine();

            Console.Write("Enter Quantity of food ordred: ");
            int quantityOrdered = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Destination Distance: ");
            int dist = Convert.ToInt32(Console.ReadLine());

            int totalBill = p7.CalculateBillAmount(foodType, quantityOrdered, dist);

            if(totalBill == -1)
            {
                Console.WriteLine("Some Input Field is wrongly entererd.");
            }
            else
            {
                Console.WriteLine("Total Bill= {0}", totalBill);
            }
            Console.ReadLine();
        }
    }
}

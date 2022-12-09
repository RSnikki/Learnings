using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques1
{
    class Program1
    {
    
            public double CalculateCostPerPerson(double mileage, double amountPerLitre, int distanceOneWay)
            {
                double costPerPerson, totalCost;
                int distance = distanceOneWay * 2;
                totalCost = (distance / mileage) * amountPerLitre;
                costPerPerson = totalCost / 4;
                return costPerPerson;
            }

            static void Main(string[] args)
            {
                Console.Write("Enter Vehicle Mileage: ");
                double mileage = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Cost of Petrol per Litre: ");
                double costPerLitre = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Distance One Way: ");
                int distanceOneWay = Convert.ToInt32(Console.ReadLine());

                Program1 p1 = new Program1();

                double costPerPerson = p1.CalculateCostPerPerson(mileage, costPerLitre, distanceOneWay);

                Console.WriteLine("Cost Each Person Has to bear for Journey in a group of 4 person: {0}", costPerPerson);

                Console.ReadLine();
            }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product vava1 = new Product();
            //Initializing object using properties
            vava1.PName = "Audio Visual Alarm";
            vava1.PPrice = 3500.50;
            vava1.PQuantityAvailable = 10;

            Console.WriteLine("Product Id: " + vava1.PId + "\tProduct Name: " + vava1.PName + "\tProduct Price: " + vava1.PPrice + "\tQuantity Available: " + vava1.PQuantityAvailable);

            //Initializing object using object initializer
            Product vtl = new Product  
            {
                PName = "Traffic Light",
                PPrice = 2555.55,
                PQuantityAvailable = 29
            };

            Console.WriteLine("Product Id: " + vtl.PId + "\tProduct Name: " + vtl.PName + "\tProduct Price: " + vtl.PPrice + "\tQuantity Available: " + vtl.PQuantityAvailable);

            Console.WriteLine("Enter Product Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Product Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Product Name: ");
            int qtyInSock = Convert.ToInt32(Console.ReadLine());

           

            Product vtt = new Product()
            {
                PName = name,
                PPrice = price,
                PQuantityAvailable = qtyInSock
            };

            Console.WriteLine("Product Id: " + vtt.PId + "\tProduct Name: " + vtt.PName + "\tProduct Price: " + vtt.PPrice + "\tQuantity Available: " + vtt.PQuantityAvailable);

            Console.ReadLine();
        }
    }
}

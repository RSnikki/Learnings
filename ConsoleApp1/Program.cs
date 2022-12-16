using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo02
{
    //Abstract Class
    public abstract class SimpleOperation
    {
        //Abstract Method - implicitly virtual need not use 'virtual' keyword
        public abstract int AddTwoNum(int a, int b);

        //Non-Abstract or Regular Method
        public int ProductTwoNum(int a, int b)
        {
            int product = a * b;
            return product;
        }

    }

    /*Non-Abstract Class inherits Abstract Class. Abstract Class acting as Base Class. As C# doesnot
    * support multiple inheritance thus a non-abstract class can only inherit one abstract class
      * And after inheriting derived class must implement abstract method of abstract class using 'override'
    * keyword */
    public class SimpleMathOperation : SimpleOperation
    {
        public override int AddTwoNum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

    }
    class Program2
    {
        public static void Main(string[] args)
        {
            //SimpleOperation d2 = new SimpleOperation();
            //Cannot instantiate Abstract Class
            SimpleMathOperation d2 = new SimpleMathOperation();

            Console.WriteLine("Simple Mathematical Operations \n");
            Console.WriteLine("Enter Two Nos.");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum: {0}", d2.AddTwoNum(a, b));
            Console.WriteLine("Product: {0}", d2.ProductTwoNum(a, b));
            Console.ReadLine();
        }
    }
}

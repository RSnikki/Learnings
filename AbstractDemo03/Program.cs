using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo03
{
    public abstract class Calculator
    {
        public abstract int A { get; set; }
        public abstract int B { get; set; }

        public abstract int Add();
        public abstract int Sub();

        public int Product()
        {
            int c = A * B;
            return c;
        }

        public abstract void Div(ref int quo, ref int rem);

    }

    public class BasicCalculator: Calculator
    {
        public override int A { get; set; }
        public override int B { get; set; }
            
        public override int Add()
        {
            int sum = A + B;
            return sum;
        }

        public override int Sub()
        {
            int diff = A - B;
            return diff;
        }

        public override void Div(ref int quo , ref int rem )
        {
            quo = A / B;
            rem = A % B;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalculator d3 = new BasicCalculator();

            Console.WriteLine("Enter for nos. for basic Operations:(Alert: 2nd Number should be greater than 0)\n");
            d3.A = Convert.ToInt32(Console.ReadLine());
            d3.B=Convert.ToInt32(Console.ReadLine());

            int quo = 0;
            int rem = 0;

            d3.Div(ref quo, ref rem);

            Console.WriteLine("Sum: {0}", d3.Add());
            Console.WriteLine("Diff: {0}", d3.Sub());
            Console.WriteLine("Product {0}", d3.Product());
            Console.WriteLine("Qoutient: {0} \nRemainder: {1}", quo, rem);

            Console.ReadLine();


        }
    }
}

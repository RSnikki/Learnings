using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques6
{
    class Program6
    {
        public int FindProduct(int num1, int num2, int num3)
        {
            if ( num2 == 7)
            {
                return num3;
            }
            else if (num3 == 7)
            {
                return -1;
            }
            else
            {
                return (num1 * num2 * num3);
            }
        }
        static void Main(string[] args)
        {
            Program6 p6 = new Program6();

            Console.Write("Enter First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Third Number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Output: {0}", p6.FindProduct(num1, num2, num3));

            Console.ReadLine();
        }
    }
}

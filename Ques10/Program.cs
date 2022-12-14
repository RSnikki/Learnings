using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques10
{
    class Program
    {
        public static int GetMagicNumbers(int number)
        {
            int numb = number, sum = 0;
            
            while( numb > 0)
            {
                sum = sum + (numb % 10);
                numb = numb / 10;
            }
            if (sum > 10)
            {
                return GetMagicNumbers(sum);
            }
            else
                return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int magicN = GetMagicNumbers(n);
            Console.WriteLine("Magic Number of {0} is {1}", n, magicN);

            Console.ReadLine();

        }
    }
}

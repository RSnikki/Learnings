using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques9
{
    class Program
    {
        public static bool findArmstrongNo(int num)
        {
            int dig, dig1, sum = 0, numb =num, num1= num, count = 0;

            while (num1 > 0)
            {
                dig1 = num1 % 10;
                count = count + 1;
                num1 = num1 / 10;
            }

            while (numb > 0)
            {
                dig = numb % 10;
                sum = (int)(sum + Math.Pow(dig, count));
                numb = numb / 10;
            }
            
            if (sum == num)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            bool result = findArmstrongNo(n);

            if (result == true)
            {
                Console.WriteLine("{0} is a Armstrong no.", n);
            }
            else
            {
                Console.WriteLine("{0} is not a Armstrong no.", n);
            }
            Console.ReadLine();

        }
    }
}

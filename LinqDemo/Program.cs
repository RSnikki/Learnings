using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //first we have to include System.Linq namespace in order to use LINQ Operators

            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            /*
            //finding minimum value without LINQ Operator
            int? result1 = null;
            foreach (int number in numbers)
            {
                if(result1 == null || number < result1)
                {
                    result1 = number;
                }
            }
            int min = (int)result1;

            //finding max value without LINQ Operator
            int? result2 = null;
            foreach (int number in numbers)
            {
                if (result2 == null || number > result2)
                {
                    result2 = number;
                }
            }
            int max = (int)result2;

            //finding sum of numbers in array without LINQ Operators
            int sum = 0, count = 0, avg;
            foreach(int number in numbers)
            {
                sum = sum + number;
                ++count;
            }
            avg = sum / count;

            Console.WriteLine("Min: {0}\nMax: {1}\nCount: {2}\nSum: {3}\nAvg: {4}\n",min, max, count, sum, avg);
            */
            //Above operation using LINQ Operators

            int min = numbers.Min();
            int max = numbers.Max();
            int sum = numbers.Sum();
            int count = numbers.Count();
            double avg = numbers.Average();
            Console.WriteLine("Min: {0}\nMax: {1}\nCount: {2}\nSum: {3}\nAvg: {4}\n", min, max, count, sum, avg);

            Console.ReadLine();
        }
    }
}

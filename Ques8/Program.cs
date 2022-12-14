using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques8
{
    class Program
    {
        public static object AmountToMake(int rupeesToMake, int noOfFive, int noOfOne)
        {
            int[] op = new int[2];
            int maxNo5 = rupeesToMake / 5;
            int minNo1 = rupeesToMake % 5;
            if (noOfFive >= maxNo5)
            {
                op[0] = maxNo5;
                op[1] = rupeesToMake - (maxNo5 * 5);
            }
            else if (noOfFive < maxNo5)
            {
                op[0] = noOfFive;
                op[1] = rupeesToMake - (noOfFive * 5);
            }
            return op;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Amount To Pay:");
            int amt = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter No. Of Five Rupee you have:");
            int noOf5 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter No. Of One Rupee you have: ");
            int noOf1 = Convert.ToInt32(Console.ReadLine());

            int[] n = new int[2];
            n = (int[])AmountToMake(amt, noOf5, noOf1);

            Console.WriteLine("No. of Five Rupee Needed: {0}\nNo. of One Rupee Needed: {1}", n[0], n[1]);
            Console.ReadLine();
        }

    }
}

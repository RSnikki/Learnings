using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques11
{
    class Program
    { 
    
        public static object FindLeapYear(int givenYear)
        {
            int[] leapYear = new int[15];


            if (givenYear % 100 == 0)
            {
                if (givenYear % 400 == 0)
                {
                    int lYear = givenYear;
                    for (int i = 0; i < 15; i++)
                    {
                        leapYear[i] = lYear;
                        lYear = lYear + 4;
                    }
                }
                else
                {
                    
                    int nearLeapYear = givenYear + 4;
                    int lYear = nearLeapYear;
                    for (int i = 0; i < 15; i++)
                    {
                        leapYear[i] = lYear;
                        lYear += 4;
                    }
                }
            }
            else if (givenYear % 4 == 0)
            {
                int lYear = givenYear;
                for (int i = 0; i < 15; i++)
                {
                    if ((lYear % 100 == 0) & (lYear % 400 != 0))
                    {
                        lYear = lYear + 4;
                        continue;
                    }
                    leapYear[i] = lYear;
                    lYear += 4;
                }

            }
            else
            {
                int gapNearLeapYear = 4 - (givenYear % 4);
                int nearLeapYear = givenYear + gapNearLeapYear;
                int lYear = nearLeapYear;
                for (int i = 0; i < 15; i++)
                {
                    if( (lYear % 100 == 0) & (lYear % 400 != 0))
                    {
                        continue;
                    }

                    leapYear[i] = lYear;
                    lYear += 4;

                }

            }

            return leapYear;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a Year: ");
            int gYear = Convert.ToInt32(Console.ReadLine());
            int[] res = new int[15];

            Console.Write("List of 15 leap year: ");
            res = (int[])FindLeapYear(gYear);
            foreach (int year in res)
            {
                Console.Write("\t{0}\t",year);
            }
            Console.ReadLine();
        }
    }
}

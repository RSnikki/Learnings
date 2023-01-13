using System;

namespace InterfaceSessionDemo
{
    interface ISimpleInterest
    {
        double CalculateInterestSI(double principal, double time, double rate);
    }

    interface ICompoundInterest
    {
        double CalculateInterestCI(double principal, double time, double rate);
    }

    public class Interest: ISimpleInterest, ICompoundInterest
    {
        public double CalculateInterestSI(double principal, double time, double rate)
        {
            double interest = principal * time * rate;
            return interest;
        }

        public double CalculateInterestCI(double principal, double time, double rate)
        {
           double x = Math.Pow((1 + rate), time);
           double interest = principal * x - principal;
           return interest;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Principal Amount: ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Time Period: ");
            double t = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Rate: ");
            double r = Convert.ToDouble(Console.ReadLine());

            Interest i = new Interest();
            


            Console.WriteLine("SI = {0}",i.CalculateInterestSI(p, t, r));

            Console.WriteLine("CI = {0}",i.CalculateInterestCI(p, t, r));
        }
    }
}

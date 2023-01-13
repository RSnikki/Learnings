using System;

namespace Abstract_Classes
{
    public abstract class Interest
    {
        
        public abstract double CalculateInterest(double principal, double time, double rate);

        public void PrintClassName1()
        {
            Console.WriteLine("Interest");
        }

    }

    public class SI : Interest
    {
        public override double CalculateInterest(double principal, double time, double rate)
        {
            double interest = principal * rate * time;
            return interest;
        }

        public double CalculateSIAmount(double principal, double time, double rate)
        {
            double amount = principal + CalculateInterest(principal, time, rate);
            return amount;
        }
    }

    public class CI : Interest
    {
       
        public override double CalculateInterest(double principal, double time, double rate)
        {
            double x = Math.Pow((1 + rate),time);
            double interest = principal * x - principal;
            return interest;
        }

        public double CalculateCIAmount(double principal, double time, double rate)
        {
            double amount = principal + CalculateInterest(principal, time, rate);
            return amount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Principal Amount: ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Rate: ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Time: ");
            double t = Convert.ToDouble(Console.ReadLine());

            SI Interest1 = new SI();
            double si1 = Interest1.CalculateInterest(p, t, r);
            double siAmount = Interest1.CalculateSIAmount(p, t, r);
            Console.WriteLine("SI= {0}; SI Amount= {1}", si1, siAmount);

            CI Interest2 = new CI();
            double ci1 = Interest2.CalculateInterest(p, t, r);
            double ciAmount = Interest2.CalculateCIAmount(p, t, r);
            Console.WriteLine("CI= {0}; CI Amount= {1}", ci1, ciAmount);

            Console.ReadLine();


        }
    }
}

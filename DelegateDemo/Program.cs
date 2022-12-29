using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate int MyDelegate(int num1, int num2);

    public class Example
        
    {
            
        // methods to be assigned and called by delegate
        public int Sum(int num1, int num2)
        {
           return num1 + num2;
        }

            
        public int Difference(int num1, int num2)
        {
           return num1 - num2;
        }

            
        public int Product(int num1, int num2)
        {
           return num1 * num2;
        }

        public int Modulo(int num1, int num2)
        {
           return num1 % num2;
        }

        public int Quotient(int num1, int num2)
        {
           return num1 / num2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Example obj = new Example();

            // Assigning the method using a constructor of the delegate
            MyDelegate sum = new MyDelegate(obj.Sum);
            // Assigning the method without the constructor of the delegate
            MyDelegate diff = obj.Difference;

            // Using delegate object to invoke the method(s)
            Console.WriteLine("Sum of two integer is = " + sum(10, 20));
            // Using Invoke() to invoke the method(s)
            Console.WriteLine("Difference of two integer is = " + diff.Invoke(20, 10));

            //More than one method can be invoked at once using multicast delegates
            Console.WriteLine("\n----- Multicast delegate operations -----");
            MyDelegate allOperations = obj.Sum;
            allOperations += obj.Difference;
            allOperations += obj.Product;
            allOperations += obj.Modulo;
            allOperations += obj.Quotient;
                
            foreach (MyDelegate delOperation in allOperations.GetInvocationList())
            {
               Console.WriteLine("Result: " + delOperation(20, 10));
            }
            Console.ReadLine();
                
        }
    }
}

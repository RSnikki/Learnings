using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo01
{
    /*Abstract modifier can be used with classes, properties, methods, indexers and events.*/
    public abstract class AbstractClass
    {
        public abstract void Print(String name);
    }

    /*Abstract class's Abstract method if not implemented in derived class will produce compile error*/
    public class Derived : AbstractClass
    {
        public override void Print(string name)
        {
            Console.WriteLine(name);
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            /*Abstract Class cannot be instantiated. To access its members we derive it in a derived class 
             and then create objects of derived class to access its members*/
            Derived d1 = new Derived();
            d1.Print("Welcome to 366Pi");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo02
{
    /*We are allowed to create a reference variable of an interface type or in other words, 
    * we are allowed to create an interface reference variable. 
    * Such kind of variable can refer to any object that implements its interface. 
    * An interface reference variable only knows that methods which are declared by its interface declaration. 
    * It does not allow accessing any other properties or methods that might be supported by the objects. 
    * This concept is similar when you use a parent class reference to access a child class object.
    */
    interface Isquare
    {
        double Side { get; set; }
        double Area();
    }

    interface Irectangle
    {
        double Length { get; set; }
        double Breadth { get; set; }

        double Area();
    }

    public class Quadrilateral : Isquare, Irectangle
    {
        public double Side { get; set; }

        public double Length { get; set; }
        public double Breadth { get; set; }
        

        double Irectangle.Area()
        {
            double Area = Length * Breadth;
            return Area;
        }

        double Isquare.Area()
        {
            double area = Math.Pow(Side, 2);
            return area;
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a reference variable of inteface type and storing object of class type(which implements interface)
            Irectangle q1 = new Quadrilateral();
            Isquare q2 = new Quadrilateral();

            Console.Write("Enter Rectangle's Length: ");
            q1.Length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Rectangle's Breadth: ");
            q1.Breadth = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Area of Rectangle: {0}", q1.Area());

            Console.Write("Enter Square's Side: ");

            //q1.Side = Convert.ToInt32(Console.ReadLine());//Will produce error. q1 cannot Side
            q2.Side = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Area of Square: {0}", q1.Area());//Will produce again area of rectangle
            Console.Write("Area of Square: {0}", q2.Area());

            Console.ReadLine();
        }
    }
}

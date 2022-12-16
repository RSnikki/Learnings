using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo01
{
    /*An interface defines a contract. A class or struct that implements an interface shall adhere to its contract.
     * The interface can contain methods, properties, events and indexers.
     * The interface merely secifies the members that shall be supplied by the class or struct, that implements
     * the interface.
     * An interface cannot contain constants, fields, operators, instance constructors, types or static members.
     * All interface members implicitly have public access. 
     * It is a compile-time error for interface member declarations to include any modifiers.
     * Interface is implicitly abstract and public including its members also.
     */
    interface Isquare
    {
        double Side { get; set; }
        double SquareArea();
    }

    interface Irectangle
    {
        double Length { get; set; }
        double Breadth { get; set; }

        double RectangleArea();
    }

    //An interface may inherit from multiple base interfaces, and a class or struct may implement multiple interfaces.

    public class Quadrilateral : Isquare, Irectangle
    {
        public double Side { get; set; }

        public double Length { get; set; }
        public double Breadth { get; set; }

        public double RectangleArea()
        {
            double Area = Length * Breadth;
            return Area;
        }

        public double SquareArea()
        {
            double area = Math.Pow(Side, 2);
            return area;   
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Quadrilateral q1 = new Quadrilateral();

            Console.Write("Enter Rectangle's Length: ");
            q1.Length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Rectangle's Breadth: ");
            q1.Breadth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Area of Rectangle: {0}",q1.RectangleArea());

            Console.Write("Enter Square's Side: ");
            q1.Side = Convert.ToInt32(Console.ReadLine());

            Console.Write("Area of Square {0}",q1.SquareArea());

            Console.ReadLine();
        }
    }
}

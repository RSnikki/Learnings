using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList is a non-generic collection
            //ArrayList is a dynamic array.
            //In ArrayList insertion and deletion can be done at any index(less than equal to count of ArrayList)

            ArrayList arr1 = new ArrayList();
            ArrayList arr2 = new ArrayList(5);

            Console.WriteLine("Capacity of ArrayList arr1: {0}",arr1.Capacity);
            Console.WriteLine("Capacity of ArrayList arr2: {0}",arr2.Capacity);

            Console.Write("Enter 1st Element into ArrayList arr1: ");
            arr1.Add((Object)Console.ReadLine());

            Console.Write("Enter 1st Element into ArrayList arr2: ");
            arr2.Add((Object)Console.ReadLine());

            Console.WriteLine("Capacity of ArrayList arr1: {0}", arr1.Capacity);
            Console.WriteLine("Capacity of ArrayList arr2: {0}", arr2.Capacity);

            arr1.Add("Csharp");
            arr1.Add('N');
            arr1.Add(5.6);
            arr1.Add(true);

            arr2.Add(12);
            arr2.Add(25);
            arr2.Add(5);
            arr2.Add(3);
            arr2.Add(16);

            Console.WriteLine("After more 4 objects in arr1 ArrayList and more 5 objects in arr2 ArrayList: ");
            Console.WriteLine("Capacity of ArrayList arr1: {0}", arr1.Capacity);
            Console.WriteLine("Capacity of ArrayList arr2: {0}", arr2.Capacity);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("No. of elements in ArrayList arr1: {0}", arr1.Count);
            Console.Write("Elements of ArrayList arr1: ");
            for(int i = 0;i<(arr1.Count); i++)
            {
                Console.Write(arr1[i]+" ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("No. of elements in ArrayList arr2: {0}", arr2.Count);
            Console.Write("Elements of ArrayList arr2: ");
            foreach (var elem in arr2)
            {
                Console.Write(elem + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(".........................Remove Operation.........................");
            arr1.Remove(5.6);
            Console.WriteLine("No. of elements in ArrayList arr1 after deletion of 5.6: {0}", arr1.Count);
            Console.Write("\nArrayList arr1 after deletion of element 5.6: ");
            foreach (var elem in arr1)
            {
                Console.Write(elem + " ");
            }

            Console.WriteLine();
            Console.WriteLine(".........................RemoveAt Operation.........................");
            arr1.RemoveAt(1);
            Console.WriteLine("No. of elements in ArrayList arr1 after deletion of element at index 1: {0}", arr1.Count);
            Console.Write("\n ArrayList arr1 after deletion of element at index 1: ");
            foreach (var elem in arr1)
            {
                Console.Write(elem + " ");
            }

            Console.WriteLine();
            Console.WriteLine(".........................Clear Operation.........................");
            arr1.Clear();
            Console.WriteLine("No. of elements in ArrayList arr1 after Clear operation: {0}", arr1.Count);
            Console.Write("\n ArrayList arr1 after Clear Operation: ");
            foreach (var elem in arr1)
            {
                Console.Write(elem + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(".........................Add Operation.........................");
            Console.WriteLine();

            Console.WriteLine("Enter No. of item to be added into arr1: ");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                Console.Write("\nEnter the object to be added: ");
                arr1.Add((object)Console.ReadLine());
            }

            Console.WriteLine("No. of elements in ArrayList arr1: {0}", arr1.Count);
            Console.Write("Elements of ArrayList arr1: ");
            for (int i = 0; i < (arr1.Count); i++)
            {
                Console.Write(arr1[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(".........................Insert Operation.........................");
       
            Console.Write("Enter value to be inserted: ");
            object ins = (object)Console.ReadLine();

            Console.Write("Enter index at which value is to be inserted: ");
            int ind = Convert.ToInt32(Console.ReadLine());

            arr1.Insert(ind, ins);

            Console.WriteLine("No. of elements in ArrayList arr1 after insertion: {0}", arr1.Count);
            Console.Write("Elements of ArrayList arr1 after insertion: ");
            for (int i = 0; i < (arr1.Count); i++)
            {
                Console.Write(arr1[i] + " ");
            }

            Console.ReadLine();
        }
    }
}

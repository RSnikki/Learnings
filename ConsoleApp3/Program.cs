using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Category category1 = new Category
            {
                CategoryName = "AudioSystem"
            };

            Category category2 = new Category
            {
                CategoryName = "Lights"
            };

            Category category3 = new Category
            {
                CategoryName = "Proximity Switch"
            };

            Category category4 = new Category
            {
                CategoryName = "Drop Gate"
            };

            //Collection Initializer without using Add Method of List
            List < Category >  list1 = new List<Category>
            { 
                category1,
                category2,
                category3
            };

            list1.Add(category4);

            foreach(var item in list1)
            {
                Console.WriteLine("Category Id: {0}\nCategory Name: {1}", item.CategoryId,item.CategoryName);
                Console.WriteLine(".",50);
            }

            Console.ReadLine();
        }
    }
}

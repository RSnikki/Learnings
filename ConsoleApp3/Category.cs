using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Category
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }

        static int counter;

        static Category()
        {
            counter = 101;
        }

        public Category()
        {
            CategoryId = "C" + (counter++);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Product
    {
        public string PId { get; set; }
        public string PName { get; set; }
        public double PPrice { get; set; }
        public int PQuantityAvailable { get; set; }

        public static int Counter;

        static Product()
        {
            Counter = 1001;
        }

        public Product()
        {
            PId = "P" + (Counter++);
        }
    }
}

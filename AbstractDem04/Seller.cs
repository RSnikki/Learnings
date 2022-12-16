using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDem04
{
    public abstract class Seller
    {
        public string SellerId;
        public string SellerName;
        public string[] SellerLocations;

        public Seller(String sellerId, String sellerName, String[] sellerLocations)
        {
            SellerId = sellerId;
            SellerName = sellerName;
            SellerLocations = sellerLocations;

        }

        //sign a contract to calculate the shipping charges among all the derived classes of Seller class
        public abstract double CalculateShippingCharges(string destinations);
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDem04
{
    class DomesticSeller:Seller
    {
        public bool ExpressDelivery;
        public DomesticSeller(string sellerId, string sellerName, string[] sellerLocations, bool expressDelivery):base(sellerId, sellerName, sellerLocations)
        {
            ExpressDelivery = expressDelivery;
        }

        //overriden method
        public override double CalculateShippingCharges(string destinations)
        {
            double shippingCharges = 0;

            if (SellerLocations.Contains(destinations))
            {
                if ((destinations.Equals("Tamilnadu")) || (destinations.Equals("Kerala")))
                {
                    shippingCharges = 50;
                }
                else
                {
                    shippingCharges = 100;
                }

                if (ExpressDelivery == true)
                {
                    shippingCharges = +250;
                }
            }
            else
            {
                shippingCharges = 0;
            }

            return shippingCharges;


        }
    }
}

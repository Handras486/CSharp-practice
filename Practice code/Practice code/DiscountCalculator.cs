using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_code
{
    public class MegaStore
    {
        public enum DiscountType
        {
            Standard,
            Seasonal,
            Weight
        }

        public static double GetDiscountedPrice(double cartWeight, double totalPrice, DiscountType discountType)
        {
            if (cartWeight > 10 && discountType == DiscountType.Weight)
            {
                return totalPrice * 0.82;
            }
            if (discountType == DiscountType.Seasonal)
            {
                return totalPrice * 0.88;
            }
 
            return totalPrice * 0.94;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_C__
{
    public delegate double Discount(double total);

    public class ShoppingCart
    {
        private Discount discount; 

        public ShoppingCart(Discount discount)
        {
            this.discount = discount; 
        }

        public double CalculateTotal(double total)
        {
            return discount(total);
        }
    }

    public class DiscountMethods
    {
        public static double NoDiscount(double total) => total;
        public static double PercentageDiscount(double total) => total - (total * 10 / 100);
        public static double FixedAmountDiscount(double total) => total - 200 > 0 ? total - 200 : 0;
    }
}


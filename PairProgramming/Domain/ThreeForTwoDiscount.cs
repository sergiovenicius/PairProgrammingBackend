using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ThreeForTwoDiscount : IDiscount
    {
        public int GetDiscount(IShoppingCart cart)
        {
            int discount = 0;
            foreach (var item in cart.GetCartProducts())
            {
                if (item.GetName().ToLower().StartsWith("jeans"))
                    discount += item.GetQuantity() / 3 * item.GetPrice();
            }

            return discount;
        }
    }
}

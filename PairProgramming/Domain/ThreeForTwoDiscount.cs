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
                if (item.Name.ToLower().StartsWith("jeans"))
                    discount += item.Quantity / 3 * item.Price;
            }

            return discount;
        }
    }
}

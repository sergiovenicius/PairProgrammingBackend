using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ThreeForTwoDiscount : IDiscount
    {
        public int GetDiscount(ICartProduct product)
        {
            if (product.GetQuantity() < 3)
                return 0;

            int total = 0;
            var qty = product.GetQuantity();
            do
            {
                total += product.GetPrice();
                qty -= 3;

            } while (qty >= 3);

            return total;
        }
    }
}

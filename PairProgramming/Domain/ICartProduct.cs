using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface ICartProduct
    {
        int GetId();

        int GetQuantity();

        int GetPrice();

        int GetTotalAmount();

        int GetDiscount();
    }
}

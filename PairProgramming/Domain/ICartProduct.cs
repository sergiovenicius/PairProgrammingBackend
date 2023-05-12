using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface ICartProduct
    {
        int Id { get; set; }
        int Quantity { get; set; }
        int Price { get; set; }
        string Name { get; set; }

        int GetTotalAmount();
    }
}

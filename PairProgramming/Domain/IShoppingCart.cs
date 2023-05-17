using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IShoppingCart
    {
        void AddCartProduct(ICartProduct newProduct);

        IReadOnlyList<ICartProduct> GetCartProducts();

        int GetTotalAmount();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly List<ICartProduct> _products;

        public ShoppingCart()
        {
            _products = new List<ICartProduct>();
        }

        public void AddCartProduct(ICartProduct newProduct)
        {
            if (_products.Exists(p => p.GetId() == newProduct.GetId()))
                throw new Exception("Product is already in the cart");

            _products.Add(newProduct);
        }

        public IReadOnlyList<ICartProduct> GetCartProducts()
        {
            return _products;

        }

        public int GetTotalAmount()
        {
            return _products.Sum(_ => _.GetTotalAmount());
        }
    }
}

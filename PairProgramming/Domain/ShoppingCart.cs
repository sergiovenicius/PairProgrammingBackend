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
        private int _discount = 0;

        public ShoppingCart()
        {
            _products = new List<ICartProduct>();
        }

        public void AddCartProduct(ICartProduct newProduct)
        {
            if (_products.Exists(p => p.Id == newProduct.Id))
                throw new Exception("Product is already in the cart");

            _products.Add(newProduct);
        }

        public IReadOnlyList<ICartProduct> GetCartProducts()
        {
            return _products;

        }

        public int GetTotalAmount()
        {
            return _products.Sum(p => p.GetTotalAmount()) - _discount;
        }

        public int GetDiscount()
        {
            return _discount;
        }

        public int ApplyDiscount(IDiscount discount)
        {
            _discount += discount.GetDiscount(this);

            return _discount;
        }

    }
}

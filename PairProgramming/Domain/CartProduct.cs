using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CartProduct: ICartProduct
    {
        private int _id;
        private string _name;
        private int _quantity;
        private int _price;
        private IDiscount _discount;

        public CartProduct(int id, string name, int quantity, int price, IDiscount discount = null)
        {
            _id = id;
            _name = name;
            _quantity = quantity;
            _price = price;
            _discount = discount;
        }

        public int GetId()
        {
            return _id;
        }

        public int GetPrice()
        {
            return _price;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public int GetDiscount()
        {
            if (_discount != null)
                return _discount.GetDiscount(this);

            return 0;
        }

        public int GetTotalAmount()
        {
            return GetPrice() * GetQuantity() - GetDiscount();
        }
    }
}

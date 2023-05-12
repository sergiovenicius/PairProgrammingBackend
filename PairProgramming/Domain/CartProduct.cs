using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CartProduct: ICartProduct
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }

        public CartProduct(int id, string name, int quantity, int price)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public int GetTotalAmount()
        {
            return Price * Quantity;
        }
    }
}

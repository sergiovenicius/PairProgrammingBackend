using Domain;
using System;
using Xunit;

namespace TestsXUnit
{
    public class ShoppingCartTest
    {
        [Fact]
        public void AddCartProductsIntoShoppingCartTest()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.AddCartProduct(new CartProduct(1, "test1", 1, 1000));
            cart.AddCartProduct(new CartProduct(2, "test2", 1, 1000));

            Assert.Equal(2, cart.GetCartProducts().Count);
        }

        [Fact]
        public void AddSameCartProductsIntoShoppingCartExceptionTest()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.AddCartProduct(new CartProduct(1, "test1", 1, 1000));

            Assert.Throws<Exception>(() => { cart.AddCartProduct(new CartProduct(1, "test1", 1, 1000)); });
        }

        [Fact]
        public void AddTShirtAndJeansIntoShoppingCartTest()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.AddCartProduct(new CartProduct(1, "T-Shirt", 1, 1000));
            cart.AddCartProduct(new CartProduct(2, "Jeans", 1, 2000));

            Assert.Equal(3000, cart.GetTotalAmount());
        }


        [Fact]
        public void SellTwoJeansTest()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.AddCartProduct(new CartProduct(2, "Jeans", 2, 1999, new ThreeForTwoDiscount()));

            Assert.Equal(3998, cart.GetTotalAmount());
        }
        [Fact]
        public void SellThreeJeansTest()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.AddCartProduct(new CartProduct(2, "Jeans", 3, 2000, new ThreeForTwoDiscount()));
            Assert.Equal(4000, cart.GetTotalAmount());
        }
        [Fact]
        public void SellFiveJeansTest()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.AddCartProduct(new CartProduct(2, "Jeans", 5, 2000, new ThreeForTwoDiscount()));

            Assert.Equal(8000, cart.GetTotalAmount());
        }
        [Fact]
        public void SellSixJeansOneShirtTest()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.AddCartProduct(new CartProduct(1, "T-Shirt", 1, 1099, new ThreeForTwoDiscount()));
            cart.AddCartProduct(new CartProduct(2, "Jeans", 6, 1999, new ThreeForTwoDiscount()));

            Assert.Equal(9095, cart.GetTotalAmount());
        }
        [Fact]
        public void SellSixJeansThreeShirtTest()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.AddCartProduct(new CartProduct(1, "T-Shirt", 3, 1000));
            cart.AddCartProduct(new CartProduct(2, "Jeans", 6, 2000, new ThreeForTwoDiscount()));

            Assert.Equal(11000, cart.GetTotalAmount());
        }
    }
}
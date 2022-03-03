namespace UnitTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using ShoppingCart;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestClass]
    public class CartTests
    {
        [TestMethod]
        public void Cart_AddItem_Test()
        {
            const int expectedCount = 1;

            //arrange
            Cart cart = new Cart();
            Item item = new Item("test", 1.23m);
            CartItem cartItem = new CartItem(item, 999);

            //act
            cart.AddItem(cartItem);
            var actualCount = cart.ItemsCount;

            //assert
            Assert.AreEqual(expectedCount, actualCount, "we expect the count to go up if we add an item.");
        }

        [TestMethod]
        public void Cart_RemoveItem_Test()
        {
            const int expectedCount = 0;

            //arrange
            Cart cart = new Cart();
            Item item = new Item("test", 1.23m);
            CartItem cartItem = new CartItem(item, 999);
            cart.AddItem(cartItem);

            //act
            cart.RemoveItem(cartItem);
            var actualCount = cart.ItemsCount;

            //assert
            Assert.AreEqual(expectedCount, actualCount, "we expect the count to go up if we add an item.");
        }

        [TestMethod]
        public void Cart_RemoveAllItems_Test()
        {
            const int expectedCount = 0;

            //arrange
            Cart cart = new Cart();
            Item item = new Item("test", 1.23m);
            CartItem cartItem = new CartItem(item, 999);
            cart.AddItem(cartItem);

            //act
            cart.RemoveAllItems();
            var actualCount = cart.ItemsCount;

            //assert
            Assert.AreEqual(expectedCount, actualCount, "we expect the count to go up if we add an item.");
        }

        [TestMethod]
        public void Cart_Checkout_Test()
        {
            const decimal TaxRate = 0.07m;

            //arrange
            Cart cart = new Cart();
            Item item = new Item("test", 1.23m);
            CartItem cartItem = new CartItem(item, 999);
            cart.AddItem(cartItem);
            var subtotal = cart.CalculateSubtotal();
            var tax = Cart.CalculateTax(subtotal, TaxRate);
            var total = Cart.CalculateTotal(subtotal, tax);

            string expectedResult = $"Item {item} Quantity {cartItem.Quantity} Subtotal {subtotal:C2}\nTax {tax:C2}\nTotal {total:C2}";

            //act
            
            var actuaResult = cart.Checkout(subtotal, tax, total);

            //assert
            Assert.AreEqual(expectedResult, actuaResult, "we expect the count to go up if we add an item.");
        }
    }
}

﻿namespace ShoppingCart
{
    using System;

    internal class Program
    {
        const decimal TaxRate = 0.07m;

        static void Main(string[] args)
        {
            Store.DisplayWelcomeMessage();
            var store = new Store();
            store.DisplayItems();

            int selection = Store.GetSelection(store.ItemsCount);

            var cart = new Cart();
            var item = new Item("Item1", 1.99m);
            var cartItem = new CartItem(item, 99);
            cart.AddItem(cartItem);
            var subtotal = cart.CalculateSubtotal();
            var tax = Cart.CalculateTax(subtotal, TaxRate);
            var total = Cart.CalculateTotal(subtotal, tax);
            cart.Checkout(subtotal, tax, total);
        }
    }
}
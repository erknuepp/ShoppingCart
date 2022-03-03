namespace ShoppingCart
{
    using System;

    internal class Program
    {
        const decimal TaxRate = 0.07m;

        static void Main(string[] args)
        {
            var cart = new Cart();
            var item = new Item("Item1", 1.99m, 99);
            cart.AddItem(item);
            var subtotal = cart.CalculateSubtotal();
            var tax = Cart.CalculateTax(subtotal, TaxRate);
            var total = Cart.CalculateTotal(subtotal, tax);
            cart.Checkout(subtotal, tax, total);
        }
    }
}
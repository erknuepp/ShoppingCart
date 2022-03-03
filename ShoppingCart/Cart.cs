namespace ShoppingCart
{
    using System;
    using System.Collections.Generic;

    public class Cart
    {
        ICollection<CartItem> items;
        public Cart()
        {
            items = new List<CartItem>();
        }

        public void AddItem(CartItem item)
        {
            items.Add(item);
        }

        public int ItemsCount => items.Count;


        public bool RemoveItem(CartItem item)
        {
            if (items.Remove(item))
            {
                return items.Remove(item);
            }
            return false;
        }

        public void RemoveAllItems()
        {
            items.Clear();
        }

        public decimal CalculateSubtotal()
        {
            decimal subtotal = 0.0m;

            foreach (CartItem item in items)
            {
                subtotal += item.Price * item.Quantity;
            }

            return subtotal;
        }

        public static decimal CalculateTax(decimal subtotal, decimal taxRate)
        {
            return subtotal * taxRate;
        }

        public static decimal CalculateTotal(decimal subtotal, decimal tax)
        {
            return subtotal + tax;
        }

        public string Checkout(decimal subtotal, decimal tax, decimal total)
        {
            var result = "";
            foreach (CartItem item in items)
            {
                result += item.ToString();
            }
            result += $"Subtotal {subtotal:C2}\nTax {tax:C2}\nTotal {total:C2}";
            return result;
        }
    }
}

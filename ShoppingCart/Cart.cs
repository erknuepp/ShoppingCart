namespace ShoppingCart
{
    using System;
    using System.Collections.Generic;

    public class Cart
    {
        ICollection<Item> items;
        public Cart()
        {
            items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public int ItemsCount => items.Count;


        public bool RemoveItem(Item item)
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

            foreach (Item item in items)
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
            foreach (Item item in items)
            {
                result += item.ToString();
            }
            result += $"Subtotal {subtotal:C2}\nTax {tax:C2}\nTotal {total:C2}";
            return result;
        }
    }
}

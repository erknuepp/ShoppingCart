namespace ShoppingCart
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Item
    {
        public string Name { get; init; }
        public decimal Price { get; init; }
        public int Quantity { get; init; }
        public Item(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        override public string ToString()
        {
            return $"{Name} {Price:C2} {Quantity}\n";
        }
    }
}

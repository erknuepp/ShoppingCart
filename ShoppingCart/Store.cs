namespace ShoppingCart
{
    using System;
    using System.Collections.Generic;

    public class Store
    {
        private readonly IList<Item> _items;
        public Store()
        {
            _items = new List<Item>
            {
                new Item("Bat", 9.79m),
                new Item("Glove", 7.57m),
                new Item("Cap", 5.35m),
                new Item("Ball", 3.13m)
            };
        }

        internal static int GetQuantity()
        {
            Console.WriteLine("\nPlease enter a quantity");
            int quantity;
            var input = Console.ReadLine();
            while (!int.TryParse(input, out quantity) || quantity <= 0 || quantity > 999)
            {
                Console.WriteLine("Opps! Please try again");
                input = Console.ReadLine();
            }
            return quantity;
        }

        internal static int GetSelection(int max)
        {
            Console.WriteLine("\nPlease select an item");
            int selection;
            var input = Console.ReadLine();
            while (!int.TryParse(input, out selection) || selection <= 0 || selection > max)
            {
                Console.WriteLine("Opps! Please try again");
                input = Console.ReadLine();
            }
            return selection;
        }

        public Store(IList<Item> items)
        {
            _items = items;
        }

        public int ItemsCount => _items.Count;
        public static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to Alexander's Baseball Imporium");
        }

        public void DisplayItems()
        {
            Console.WriteLine($"Item Price");
            Console.WriteLine($"---- -----");
            int i = 1;
            foreach (var item in _items)
            {
                Console.WriteLine($" ({i++}) {item.Name} {item.Price:C2}");
            }
        }

        public Item GetItem(int selection)
        {
            return _items[selection-1];
        }
    }
}

namespace ShoppingCart
{
    public class Item
    {
        public string Name { get; init; }
        public decimal Price { get; init; }
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        override public string ToString()
        {
            return $"{Name} {Price:C2}\n";
        }
    }
}
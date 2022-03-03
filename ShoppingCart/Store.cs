namespace ShoppingCart
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Store
    {
        ICollection<Item> items;
        public Store()
        {
            items = new List<Item>();
            items.Add(new Item("Bat", 9.79m));
            items.Add(new Item("Glove", 7.57m));
            items.Add(new Item("Cap", 5.35m));
            items.Add(new Item("Ball", 3.13m));
        }
    }
}

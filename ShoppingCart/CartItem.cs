namespace ShoppingCart
{
    public class CartItem
    {
        private readonly Item _item;
        private int _quantity;

        public decimal Price => _item.Price;
        public decimal Quantity => _quantity;

        public CartItem(Item item, int quantity)
        {
            _item = item;
            _quantity = quantity;
        }

        public void UpdateQuantity(int quantity)
        {
            _quantity = quantity;
        }

        public override string ToString()
        {
            return $"Item {_item} Quantity {_quantity} ";
        }
    }
}

namespace ControlePedidos.Entities
{
    class OrderItem
    {
        public int Quantity {private set; get; }
        public double Price {private set; get; }
        public Product Product = new Product();

        public OrderItem() { }
        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

    }
}

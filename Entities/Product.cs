
namespace ControlePedidos.Entities
{
    class Product
    {
        public string Name { set; get; }
        public double Price { set; get; }
        
        //Construtor
        public Product() { }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            
        }
    }

    
}

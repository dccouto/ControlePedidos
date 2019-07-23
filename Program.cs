using System;
using System.Globalization;
using ControlePedidos.Entities;
using ControlePedidos.Entities.Enums;

namespace ControlePedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Client client_1 = new Client(name, email, date);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = new OrderStatus();
            Enum.TryParse(Console.ReadLine(), out status);
            
            Console.Write("How many items to this order? ");
            int quant = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, status);
            order.client = client_1;

            for(int i = 1; i <= quant; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Product product = new Product(prodName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(quantity, price);
                orderItem.Product = product;

                order.AddItem(orderItem);


            }
            Console.WriteLine(order);
        }
    }
}

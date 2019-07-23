using System;
using System.Collections.Generic;
using System.Globalization;
using ControlePedidos.Entities.Enums;

namespace ControlePedidos.Entities
{
    class Order
    {
        public DateTime Moment { set; get; }
        public OrderStatus Status { set; get; }
        public Client client = new Client();
        List<OrderItem> orderItems = new List<OrderItem>();
        //------------------------------------------

        //Constutores
        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }
        //------------------------------------------
        public void AddItem(OrderItem item)
        {
            orderItems.Add(item);
        }
        //------------------------------------------

        public void RemoveItem(OrderItem item)
        {
            orderItems.Remove(item);
        }
        //------------------------------------------
        public double Total()
        {
            double total = 0;

            foreach(OrderItem item in orderItems)
            {
                total += item.SubTotal();
            }

            return total;
        }
        //------------------------------------------

        public override string ToString()
        {
            Console.Write("\nORDER SUMARY:\n" +
                $"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}\n" +
                $"Order Status: {Status}\n" +
                $"Client: {client.Name} ({client.BirthDate.ToString("dd/MM/yyyy")}) - {client.Email}\n" +
                $"Order items:\n");
            foreach (OrderItem item in orderItems)
            {
                Console.Write($"{item.Product.Name}, ${item.Product.Price.ToString("F2",CultureInfo.InvariantCulture)}, Quantity: {item.Quantity}, Subtotal: ${item.SubTotal().ToString("F2",CultureInfo.InvariantCulture)}\n");
            }
            return $"Total price: ${Total().ToString("F2", CultureInfo.InvariantCulture)})";
            
            
        }
    }
}

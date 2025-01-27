using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenChillyShop.Models
{
    //This class represents an order  placed by customer
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }  // Customer placing the order
        public DateTime OrderDate { get; set; }  // Date the order was placed
        public decimal TotalAmount { get; set; }  // Total amount of the order
        public string OrderStatus { get; set; }  // Status of the order (e.g., Pending, Delivered)
        public List<OrderItem> OrderItems { get; set; }  // List of items in the order
    }
}

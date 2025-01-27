using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenChillyShop.Models
{
    //This represents each individual item in the order.
    public class OrderItem
    {
        public int Id { get; set; }  // Unique identifier for the order item
        public int OrderId { get; set; }  // Associated order
        public int ProductId { get; set; }  // Product being bought
        public int Quantity { get; set; }  // Quantity of the product in the order
        public decimal Price { get; set; }  // Price of the product at the time of the order
        public decimal TotalPrice { get; set; }  // Total price for this item (Price * Quantity)
    
    }
}

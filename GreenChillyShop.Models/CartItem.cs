using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenChillyShop.Models
{
    public class CartItem
    {
        public int Id { get; set; }  // Unique identifier for the cart item
        public int CartId { get; set; }  // Associated cart
        public int ProductId { get; set; }  // Product being added to the cart
        public int Quantity { get; set; }  // Quantity of the product in the cart
        public decimal Price { get; set; }  // Price of the product
        public decimal TotalPrice { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenChillyShop.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }  // Unique identifier for the cart
        public int CustomerId { get; set; }  // Customer owning the cart
        public List<CartItem> CartItems { get; set; }  // List of items in the cart
    }
}

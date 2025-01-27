using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenChillyShop.Models
{
    public class Payment
    {
        public int Id { get; set; }  // Unique identifier for the payment
        public int OrderId { get; set; }  // Associated order
        public decimal Amount { get; set; }  // Amount paid
        public string PaymentMethod { get; set; }  // Payment method (e.g., Credit Card, Cash)
        public DateTime PaymentDate { get; set; }  // Date of payment
        public string PaymentStatus { get; set; }
    }
}

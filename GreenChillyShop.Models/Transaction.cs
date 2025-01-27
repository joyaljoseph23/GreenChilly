using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenChillyShop.Models
{
    public class Transaction
    {
        public int Id { get; set; }  // Unique transaction ID
        public int PaymentId { get; set; }  // Associated payment
        public DateTime TransactionDate { get; set; }  // Date of the transaction
        public string TransactionStatus { get; set; }  // Transaction status (e.g., Successful, Failed)
    }
}

using System.ComponentModel.DataAnnotations;

namespace BankApplication.Models
{
    public class Transaction
    {
        [Key]
        public int id { get; set; }

        public string type { get; set; }

        public DateTime date { get; set; }

        public decimal amount { get; set; }

        public decimal commission { get; set; }

        public string commission_type { get; set; }

        public decimal commission_amount { get; set; }

        public int account_id { get; set; }
    }
}

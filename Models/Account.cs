using System.ComponentModel.DataAnnotations;

namespace BankApplication.Models
{
 
    public class Account
    {
        [Key]
        public int id { get; set; }
        public string number { get; set; }
        public DateTime open_date { get; set; }
        public int owner_id { get; set; }
        public decimal balance { get; set; }

    }
}

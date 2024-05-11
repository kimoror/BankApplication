using System.ComponentModel.DataAnnotations;

namespace BankApplication.Models
{
    public class Client
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string phone { get; set; }

        [Required]
        public string address { get; set; }

        public string client_fullname { get; set; }

        public string sex { get; set; }

        public DateTime birth_date { get; set; }

        public bool is_debtor { get; set; }
    }
}

using BankApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace BankApplication.Data
{
    public class BankDbContext : DbContext
    {

        public BankDbContext(DbContextOptions<BankDbContext> options) : base(options)
        {
            
        }


        public DbSet<Account> Accounts { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<LegalClientInfo> LegalClientInfos { get; set; }

        public DbSet<PhysClientInfo> PhysClientInfo { get; set; }

        public DbSet<Transaction> Tra { get; set; }
    }
}

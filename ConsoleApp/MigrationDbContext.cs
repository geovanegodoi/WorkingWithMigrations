using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MigrationDbContext : DbContext
    {
        public MigrationDbContext() : base("name=DefaultConnection")
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<AccountType> AccountTypes { get; set; }

        public DbSet<Account> Accounts { get; set; }
    }
}

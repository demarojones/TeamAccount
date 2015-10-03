using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamAccount.DAL.Entities;

namespace TeamAccount.DAL
{
    public class TeamAccountContext: DbContext
    {
        public TeamAccountContext() : base("name=TeamAccount")
        {
            Database.SetInitializer<TeamAccountContext>(null);
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountTransaction> AccountTransactions { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }
        public DbSet<TransactionStatus> TransactionStatus { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserLogin> Logins { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TeamAccount.DAL.Entities;

namespace TeamAccount.API.Models
{
    public class TeamAccountAPIContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public TeamAccountAPIContext() : base("name=TeamAccountContext")
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountTransaction> AccountTransactions { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }
        public DbSet<TransactionStatus> TransactionStatus { get; set; }
        public DbSet<TransactionItem> Transactions { get; set; }
        public DbSet<Player> Users { get; set; }
        public DbSet<UserLogin> Logins { get; set; }
    
    }
}

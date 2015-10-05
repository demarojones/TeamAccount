using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamAccount.DAL.Entities;
using System.Configuration;
namespace TeamAccount.DAL
{
    public class TeamAccountContext: DbContext
    {
        public TeamAccountContext() : base(nameOrConnectionString : ConnectionStringName)
        {
           // Database.SetInitializer<TeamAccountContext>(null);
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountTransaction> AccountTransactions { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }
        public DbSet<TransactionStatus> TransactionStatus { get; set; }
        public DbSet<TransactionItem> Transactions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserLogin> Logins { get; set; }

        public static string ConnectionStringName
        {
            get
            {
                if (ConfigurationManager.AppSettings["ConnectionStringName"] != null)
                {
                    return ConfigurationManager.AppSettings["ConnectionStringName"].ToString();
                }
                return "TeamAccountAPIContext";
            }
        }
    }
}

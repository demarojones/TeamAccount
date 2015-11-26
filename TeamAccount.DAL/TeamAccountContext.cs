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
            Database.SetInitializer<TeamAccountContext>(null);
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<TransactionStatus> TransactionStatus { get; set; }
        public virtual DbSet<TransactionType> TransactionTypes { get; set; }

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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.AccountName)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Transactions)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.TeamName)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.TeamDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.TeamCoach)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.Players)
                .WithRequired(e => e.Team)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.TransactionName)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.TransactionDescription)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionStatus>()
                .Property(e => e.StatusName)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionStatus>()
                .Property(e => e.StatusDescription)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionType>()
                .Property(e => e.TypeName)
                .IsUnicode(false);
        }
    }
}

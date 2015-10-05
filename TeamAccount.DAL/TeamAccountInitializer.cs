using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TeamAccount.DAL.Entities;

namespace TeamAccount.DAL
{
    public class TeamAccountInitializer : DropCreateDatabaseAlways<TeamAccountContext>
    {
        protected override void Seed(TeamAccountContext context)
        {
            var users = new List<User>
            {
                new User(){FirstName="Demaro", LastName="Jones", Email="newuser@email.com", UserName="djones01"},
                new User(){FirstName="Jason", LastName="Weekley", Email="jweeks@email.com", UserName="jweeks02"},
                new User(){FirstName="Ryan", LastName="Goslin", Email="rgoslyn@email.com", UserName="rgoslyn03"},
                new User(){FirstName="Jack", LastName="Bauer", Email="jbauer@email.com", UserName="jbauer04"}
            };

            users.ForEach(u => context.Users.Add(u));
                context.SaveChanges();

            var userLogins = new List<UserLogin>
            {
                new UserLogin(){UserId=1, UserName="djones01", PasswordHash="PWhA$H", PasswordSalt="pwdSaLt", user=users[0]},
                new UserLogin(){UserId=2, UserName="jweeks02", PasswordHash="PWhA$H", PasswordSalt="pwdSaLt", user=users[1]},
                new UserLogin(){UserId=3, UserName="rgoslyn03", PasswordHash="PWhA$H", PasswordSalt="pwdSaLt", user=users[2]},
                new UserLogin(){UserId=4, UserName="jbauer04", PasswordHash="PWhA$H", PasswordSalt="pwdSaLt", user=users[3]}
            };
            userLogins.ForEach(ul => context.Logins.Add(ul));
            context.SaveChanges();
            var teams = new List<Team>
            {
                new Team(){TeamName="CFCA PREMIER", TeamDescription="CFCA PREMIER Under 9 Team"},
                new Team(){TeamName="CFCA ELITE", TeamDescription="CFCA ELITE Under 9 Team"},
                new Team(){TeamName="CFCA SELECT", TeamDescription="CFCA SELECT Under 9 Team"}
            };
            teams.ForEach(ul => context.Teams.Add(ul));
            context.SaveChanges();
            
            var transactionStatus = new List<TransactionStatus>
            {
                new TransactionStatus(){StatusName="Completed", StatusDescription="Transaction is complete"},
                new TransactionStatus(){StatusName="Pending", StatusDescription="Transaction is Pending..."},
                new TransactionStatus(){StatusName="Awaiting Response", StatusDescription="Transaction is awaiting response"}
            };
            transactionStatus.ForEach(ul => context.TransactionStatus.Add(ul));
            context.SaveChanges();

            var transactionItems = new List<TransactionItem>
            {
                new TransactionItem(){ItemName="Team Fee", ItemDescription="Team Fees"},
                new TransactionItem(){ItemName="Tournament Fee", ItemDescription="Tournament fees..."},
                new TransactionItem(){ItemName="Coaching Hotel Expense", ItemDescription="Coaching expenses"}
            };
            transactionItems.ForEach(ul => context.Transactions.Add(ul));
            context.SaveChanges();

             var transactionTypes = new List<TransactionType>
            {
                new TransactionType(){TypeName="Payment"},
                new TransactionType(){TypeName="Charge"},
                new TransactionType(){TypeName="Refund"}
            };
            transactionTypes.ForEach(ul => context.TransactionTypes.Add(ul));
            context.SaveChanges();

            var account = new Account(){AccountName="BalanceAccount", TeamId=teams[0].Id, Balance=235.65m, AccountCreated= new DateTime(2012,12,12)};
            var transactions = new List<AccountTransaction>
            {
                new AccountTransaction(){Account=account, TransactionAmount=56.67m, TransactionItem=transactionItems[0], TransactionStatus = transactionStatus[0], TransactionType=transactionTypes[0], TransactionDate=DateTime.Now},
                new AccountTransaction(){Account=account, TransactionAmount=105.99m, TransactionItem=transactionItems[0], TransactionStatus = transactionStatus[0], TransactionType=transactionTypes[0], TransactionDate=DateTime.Now},
                new AccountTransaction(){Account=account, TransactionAmount=220.56m, TransactionItem=transactionItems[0], TransactionStatus = transactionStatus[0], TransactionType=transactionTypes[0], TransactionDate=DateTime.Now}
            };
            context.Accounts.Add(account);
            transactions.ForEach(a => context.AccountTransactions.Add(a));
            context.SaveChanges();

            account = new Account(){AccountName="BalanceAccount", TeamId=teams[1].Id, Balance=235.65m, AccountCreated= new DateTime(2013,6,9)};
            transactions = new List<AccountTransaction>
            {
                new AccountTransaction(){Account=account, TransactionAmount=56.67m, TransactionItem=transactionItems[1], TransactionStatus = transactionStatus[2], TransactionType=transactionTypes[0], TransactionDate=DateTime.Now},
                new AccountTransaction(){Account=account, TransactionAmount=105.99m, TransactionItem=transactionItems[0], TransactionStatus = transactionStatus[0], TransactionType=transactionTypes[2], TransactionDate=DateTime.Now},
                new AccountTransaction(){Account=account, TransactionAmount=220.56m, TransactionItem=transactionItems[2], TransactionStatus = transactionStatus[1], TransactionType=transactionTypes[1], TransactionDate=DateTime.Now}
            };
            context.Accounts.Add(account);
            transactions.ForEach(a => context.AccountTransactions.Add(a));
            context.SaveChanges();


            account = new Account() { AccountName = "BalanceAccount", TeamId = teams[0].Id, Balance = 235.65m, AccountCreated = new DateTime(2014, 9, 10) };
            transactions = new List<AccountTransaction>
            {
                new AccountTransaction(){Account=account, TransactionAmount=56.67m, TransactionItem=transactionItems[2], TransactionStatus = transactionStatus[2], TransactionType=transactionTypes[2], TransactionDate=DateTime.Now},
                new AccountTransaction(){Account=account, TransactionAmount=105.99m, TransactionItem=transactionItems[0], TransactionStatus = transactionStatus[0], TransactionType=transactionTypes[1], TransactionDate=DateTime.Now},
                new AccountTransaction(){Account=account, TransactionAmount=220.56m, TransactionItem=transactionItems[2], TransactionStatus = transactionStatus[1], TransactionType=transactionTypes[1], TransactionDate=DateTime.Now}
            };
            context.Accounts.Add(account);
            transactions.ForEach(a => context.AccountTransactions.Add(a));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}

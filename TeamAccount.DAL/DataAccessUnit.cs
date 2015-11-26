using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamAccount.DAL.Entities;
using TeamAccount.DAL;
using TeamAccount.DAL.Repositories;

namespace TeamAccount.DAL
{
    public class DataAccessUnit : IDisposable
    {
        private TeamAccountContext _context = new TeamAccountContext();
        private IRepository<Account> _accounts = null;
        private IRepository<Transaction> _transactions = null;
        
        public IRepository<Account> Accounts
        {
            get
            {
                if (this._accounts == null)
                {
                    this._accounts = new GenericRepository<Account>(this._context);
                }
                return this._accounts;
            }
        }

        public IRepository<Transaction> Transactions
        {
            get
            {
                if (this._transactions == null)
                {
                    this._transactions = new GenericRepository<Transaction>(this._context);
                }
                return this._transactions;
            }
        }

        public void SaveChanges()
        {
            this._context.SaveChanges();
        }

        public void Dispose()
        {
            if (this._context != null)
            {
                this._context.Dispose();
            }
        }
    }
}

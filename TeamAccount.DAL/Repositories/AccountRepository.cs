using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TeamAccount.DAL.Entities;

namespace TeamAccount.DAL.Repositories
{
    public class AccountRepository : GenericRepository<Account>
    {

        public AccountRepository(DbContext context) : base(context)
        {}
    }
}

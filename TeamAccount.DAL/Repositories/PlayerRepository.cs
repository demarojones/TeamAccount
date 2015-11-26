using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamAccount.DAL.Entities;

namespace TeamAccount.DAL.Repositories
{
    public class PlayerRepository : GenericRepository<Player>
    {
        public PlayerRepository(DbContext context):base(context)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamAccount.DAL.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string TeamId { get; set; }
        public int Balance { get; set; }
        public DateTime AccountCreated { get; set; }

        //Navigation
        public ICollection<Transaction> Transactions { get; set; }
        public virtual Team group { get; set; }
    }
}

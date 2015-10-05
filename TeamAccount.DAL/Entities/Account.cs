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
        public int TeamId { get; set; }
        public decimal Balance { get; set; }
        public DateTime AccountCreated { get; set; }

        //Navigation
        public ICollection<Transaction> Transactions { get; set; }
        public virtual Team Team { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamAccount.DAL.Entities
{
    public class AccountTransaction
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int TransactionTypeId { get; set; }
        public int TransactionStatusId { get; set; }
        public int TransactionItemId { get; set; }
        public decimal TransactionAmount { get; set; }
        //Navigation
        public virtual Account Account { get; set; }
        public virtual TransactionType TransactionType { get; set; }
        public virtual TransactionStatus TransactionStatus { get; set; }
        public virtual TransactionItem TransactionItem { get; set; }
    }
}

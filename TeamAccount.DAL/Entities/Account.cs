namespace TeamAccount.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        public Account()
        {
            Transactions = new HashSet<Transaction>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string AccountName { get; set; }

        public int PlayerId { get; set; }

        public decimal Balance { get; set; }

        public DateTime AccountCreated { get; set; }

        public virtual Player Player { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}

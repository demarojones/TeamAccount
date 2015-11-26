namespace TeamAccount.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TransactionStatus
    {
        public TransactionStatus()
        {
            Transactions = new HashSet<Transaction>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string StatusName { get; set; }

        [StringLength(100)]
        public string StatusDescription { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}

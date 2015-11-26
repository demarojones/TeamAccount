namespace TeamAccount.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransactionType")]
    public partial class TransactionType
    {
        public TransactionType()
        {
            Transactions = new HashSet<Transaction>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string TypeName { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}

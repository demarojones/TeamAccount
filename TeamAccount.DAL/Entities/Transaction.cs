namespace TeamAccount.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transaction")]
    public partial class Transaction
    {
        public int Id { get; set; }

        public int AccountId { get; set; }

        [Required]
        [StringLength(50)]
        public string TransactionName { get; set; }

        [StringLength(100)]
        public string TransactionDescription { get; set; }

        public int TransactionTypeId { get; set; }

        public int TransactionStatusId { get; set; }

        public decimal TransactionAmount { get; set; }

        public DateTime TransactionDate { get; set; }

        //Navigation Properties
        public virtual Account Account { get; set; }

        public virtual TransactionStatus TransactionStatus { get; set; }

        public virtual TransactionType TransactionType { get; set; }
    }
}

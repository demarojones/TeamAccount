namespace TeamAccount.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Player")]
    public partial class Player
    {
        public Player()
        {
            Accounts = new HashSet<Account>();
        }

        public int Id { get; set; }

        public int TeamId { get; set; }

        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }

        public virtual Team Team { get; set; }
    }
}

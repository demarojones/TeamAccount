namespace TeamAccount.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Team")]
    public partial class Team
    {
        public Team()
        {
            Players = new HashSet<Player>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string TeamName { get; set; }

        [StringLength(100)]
        public string TeamDescription { get; set; }

        [StringLength(50)]
        public string TeamCoach { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}

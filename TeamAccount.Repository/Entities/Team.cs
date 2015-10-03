using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamAccount.DAL.Entities
{
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public string TeamDescription { get; set; }
    }
}

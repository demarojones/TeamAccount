using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamAccount.DTO
{
    public class Account
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Status { get; set; }

        public virtual ICollection<Expense> expenses { get; set; }
    }
}

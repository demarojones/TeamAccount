using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamAccount.DAL.Entities
{
    public class TransactionStatus
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
        public string StatusDescription { get; set; }
    }
}

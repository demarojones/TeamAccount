using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamAccount.DTO
{
    public class Payment
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public string PaymentDate { get; set; }
    }
}

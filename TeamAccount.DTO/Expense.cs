using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamAccount.DTO
{
    public class Expense
    {
        public int Id { get; set; }
        public int ExpenseGroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Amount { get; set; }
        public DateTime Date { get; set; }

        //Navigation
        public virtual ICollection<Payment> payments { get; set; }

    }
}
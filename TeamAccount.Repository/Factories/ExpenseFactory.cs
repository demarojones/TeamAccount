using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamAccount.DTO;

namespace TeamAccount.Repository.Factories
{
    public class ExpenseFactory
    {
        public ExpenseFactory()
        {

        }

        public Expense CreateExpense(Expense expense)
        {
            return new Expense()
            {
                Amount = expense.Amount,
                Date = expense.Date,
                Description = expense.Description,
                ExpenseGroupId = expense.ExpenseGroupId,
                Id = expense.Id
            };
        }



        public Expense CreateExpense(Expense expense)
        {
            return new Expense()
            {
                Amount = expense.Amount,
                Date = expense.Date,
                Description = expense.Description,
                GroupId = expense.GroupId,
                Id = expense.Id
            };
        }
    }
}

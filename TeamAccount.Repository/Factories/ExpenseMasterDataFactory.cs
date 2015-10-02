using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamAccount.Repository.Entities;

namespace TeamAccount.Repository.Factories
{
    public class ExpenseMasterDataFactory
    {
        public ExpenseMasterDataFactory()
        {

        }



        public ExpenseGroupStatus CreateExpenseGroupStatus(DTO.ExpenseGroupStatus expenseGroupStatus)
        {
            return new ExpenseGroupStatus()
            {
                Description = expenseGroupStatus.Description,
                Id = expenseGroupStatus.Id
            };
        }


        public DTO.ExpenseGroupStatus CreateExpenseGroupStatus(ExpenseGroupStatus expenseGroupStatus)
        {
            return new DTO.ExpenseGroupStatus()
            {
                Description = expenseGroupStatus.Description,
                Id = expenseGroupStatus.Id
            };
        }
    }
}

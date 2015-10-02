using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamAccount.Repository
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        void Add(T entry);
        void update(T entry);
        void delete(T entry);
        void deleteById(int id);
        void Detach(T entity);
    }
}

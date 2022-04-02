using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace receitas.dominio.Models.Base
{
    public interface IRepoBase<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();

        T Get(int id);
        void Insert(T entity);
        void update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}

using receitas.dominio.Models.Base;
using receitas.dominio.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace receitas.Repository.Repositorys.RepoCustomer
{
    public interface ICustomerRepo : IRepoBase<Customer>
    {
        IEnumerable<Customer> GetCustomerByName(string name);
    }
}

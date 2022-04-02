using Microsoft.EntityFrameworkCore;
using receitas.dominio.Models.Customers;
using receitas.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace receitas.Repository.Repositorys.RepoCustomer
{
    internal class CustomerRepo : ICustomerRepo
    {
        private readonly ReceitasDBContext _ReceitasContext;
        private DbSet<Customer> customer;

        public CustomerRepo(ReceitasDBContext receitasContext)
        {
            _ReceitasContext = receitasContext;
            customer = _ReceitasContext.Set<Customer>();
        }
        public void Delete(Customer entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Erro no delete de clientes");
            }
            customer.Remove(entity);
            _ReceitasContext.SaveChanges();
        }

        public Customer Get(int id)
        {
            return customer.SingleOrDefault(e => e.Id == id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return customer.AsEnumerable();
        }

        public IEnumerable<Customer> GetCustomerByName(string name)
        {
            return _ReceitasContext.Customers.Where(e => e.CustomerName.Contains(name));
        }

        public void Insert(Customer entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Erro no insert de clientes");
            }
            customer.Add(entity);
            _ReceitasContext.SaveChanges();
        }

        public void Remove(Customer entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Erro no remove de clientes");
            }
            customer.Remove(entity);
        }

        public void SaveChanges()
        {
            _ReceitasContext.SaveChanges();
        }

        public void update(Customer entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Erro no update de clientes");
            }
            customer.Update(entity);
            _ReceitasContext.SaveChanges();
        }
    }
}

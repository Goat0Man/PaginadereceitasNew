using Microsoft.EntityFrameworkCore;
using receitas.dominio.Models.Base;
using receitas.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace receitas.Repository.Repositorys
{
    
        public class RepoBase<T> : IRepoBase<T> where T : BaseEntity
        {
            private readonly ReceitasDBContext _ReceitasContext;
            private DbSet<T> entities;

            public RepoBase(ReceitasDBContext ReceitasContext)
            {
            _ReceitasContext = ReceitasContext;
                entities = _ReceitasContext.Set<T>();
            }


            public void Delete(T entity)
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("Erro no delete de entidades");
                }
                entities.Remove(entity);
            _ReceitasContext.SaveChanges();
            }

            public T Get(int id)
            {
                return entities.SingleOrDefault(e => e.Id == id);
            }

            public IEnumerable<T> GetAll()
            {
                return entities.AsEnumerable();
            }

            public void Insert(T entity)
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("Erro no insert de entidades");
                }
                entities.Add(entity);
            _ReceitasContext.SaveChanges();
            }

            public void Remove(T entity)
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("Erro no remove de entidades");
                }
                entities.Remove(entity);

            }

            public void SaveChanges()
            {
            _ReceitasContext.SaveChanges();
            }

            public void update(T entity)
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("Erro no update de entidades");
                }
                entities.Update(entity);
            _ReceitasContext.SaveChanges();
            }
        }
    }


using Microsoft.EntityFrameworkCore;
using receitas.dominio.Models.Ingredients;
using receitas.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace receitas.Repository.Repositorys.RepoIngredient
{
        internal class IngredientRepo : IIngredientRepo
        {
            private readonly ReceitasDBContext _ReceitasContext;
            private DbSet<Ingredient> ingredient;

            public IngredientRepo(ReceitasDBContext receitasContext)
            {
                _ReceitasContext = receitasContext;
                ingredient = _ReceitasContext.Set<Ingredient>();
            }
            public void Delete(Ingredient entity)
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("Erro no delete de clientes");
                }
            ingredient.Remove(entity);
                _ReceitasContext.SaveChanges();
            }

            public Ingredient Get(int id)
            {
                return ingredient.SingleOrDefault(e => e.Id == id);
            }

            public IEnumerable<Ingredient> GetAll()
            {
                return ingredient.AsEnumerable();
            }


            public void Insert(Ingredient entity)
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("Erro no insert de clientes");
                }
            ingredient.Add(entity);
                _ReceitasContext.SaveChanges();
            }

            public void Remove(Ingredient entity)
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("Erro no remove de clientes");
                }
            ingredient.Remove(entity);
            }

            public void SaveChanges()
            {
                _ReceitasContext.SaveChanges();
            }

            public void update(Ingredient entity)
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("Erro no update de clientes");
                }
            ingredient.Update(entity);
                _ReceitasContext.SaveChanges();
            }
        }
}

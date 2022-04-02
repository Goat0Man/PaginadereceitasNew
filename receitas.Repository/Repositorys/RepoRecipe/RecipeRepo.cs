using Microsoft.EntityFrameworkCore;
using receitas.dominio.Models.Base;
using receitas.dominio.Models.Receips;
using receitas.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace receitas.Repository.Repositorys.RepoRecipe
{
    public class RecipeRepo : IRecipeRepo
    {
        private readonly ReceitasDBContext _ReceitasContext;
        private DbSet<Recipe> recipe;

        public void Delete(Recipe entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Erro no delete da receita");
            }
            recipe.Remove(entity);
            _ReceitasContext.SaveChanges();
        }

        public Recipe Get(int id)
        {
            return recipe.SingleOrDefault(e => e.Id == id);
        }

        public IEnumerable<Recipe> GetAll()
        {
            return recipe.AsEnumerable();
        }

        public IEnumerable<Recipe> GetRecipebyId(int id)
        {
            return _ReceitasContext.Recipes.Where(e => e.Id == id);
        }

        public void Insert(Recipe entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Erro a inserir a receita");
            }
            recipe.Add(entity);
            _ReceitasContext.SaveChanges();
        }

        public void Remove(Recipe entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Erro a remover a receita");
            }
            recipe.Remove(entity);
        }

        public void SaveChanges()
        {
            _ReceitasContext.SaveChanges();
        }

        public void update(Recipe entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Erro no update de receitas");
            }
            recipe.Update(entity);
            _ReceitasContext.SaveChanges();
        }
    }
}

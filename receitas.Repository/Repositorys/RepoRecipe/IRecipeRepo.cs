using receitas.dominio.Models.Base;
using receitas.dominio.Models.Receips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace receitas.Repository.Repositorys.RepoRecipe
{
    public interface IRecipeRepo : IRepoBase<Recipe>
    {
        IEnumerable<Recipe> GetRecipebyId(int id);
    }
}

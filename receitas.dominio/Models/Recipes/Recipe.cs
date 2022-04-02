using receitas.dominio.Models.Base;
using receitas.dominio.Models.Ingredients;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace receitas.dominio.Models.Receips
{
    public class Recipe : BaseEntity
    {
        public string RecipeName { get; set; }
        public string RecipeInfo { get; set; }
        public string IngredientId { get; set; }
        [ForeignKey("IngredientID")]
        public string RecipeIngredients { get; set; }
        public List<Ingredient> ingredients { get; set; }
    }
}

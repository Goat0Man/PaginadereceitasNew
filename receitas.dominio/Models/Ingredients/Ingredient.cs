using receitas.dominio.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace receitas.dominio.Models.Ingredients
{
    public class Ingredient : BaseEntity
    {
        public string IngredientName { get; set; }

        public int IngredientAmount{ get; set; }

    }
}

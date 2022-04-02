using Microsoft.EntityFrameworkCore;
using receitas.dominio.Models.Admins;
using receitas.dominio.Models.Customers;
using receitas.dominio.Models.Ingredients;
using receitas.dominio.Models.Receips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace receitas.Repository.Models
{
    public class ReceitasDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

    }
}

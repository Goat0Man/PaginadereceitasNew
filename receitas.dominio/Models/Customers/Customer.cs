using receitas.dominio.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace receitas.dominio.Models.Customers
{
    public class Customer : BaseEntity
    {
        [Column(TypeName = "nvarchar(100)")]
        public string CustomerName { get; set; }
        public string Adress { get; set; }
    }
}

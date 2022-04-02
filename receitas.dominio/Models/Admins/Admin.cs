using receitas.dominio.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace receitas.dominio.Models.Admins
{
    public class Admin : BaseEntity
    {
        public string AdminName { get; set; }
        public string AdminPassword { get; set; }
       
    }
}

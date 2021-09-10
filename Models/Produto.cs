using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GropuProdutos.Models
{
    public class Produto
    {
        [Key]
        public int Codigo { get; set; }
        public String Descricao { get; set; }
        public bool Status { get; set; }
    }
}

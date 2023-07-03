using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.CodeDom.Compiler;

namespace GestaoPI.Models
{

    [Table(name: "tipo_programa")]
    public class TipoPrograma
    {
        [Key]
        [Column("codigo")]
        public string Codigo {get; set;} = null!;

        [Column("descricao")]
        public string? Descricao {get; set;}

    }
}
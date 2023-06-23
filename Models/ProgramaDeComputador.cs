using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoPI.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoPI.Models
{
    [Table("programa_de_computador")]
    public class ProgramaDeComputador : IProcesso
    {
        [Key]
        [Column("cod_programa_de_computador")]
        public string Codigo {get; set;} = null!;

        [Column("titulo")]
        public string? Titulo {get; set;}

        [Column("deposito")]
        public DateTime Deposito {get; set;}

        public DateTime? Concessao {get; set;}

        public virtual ICollection<Inventor>? Inventores {get; set;} = new List<Inventor>();
    }
}
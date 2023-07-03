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

        public virtual ICollection<DespachoProgramaDeComputador> Despachos {get; set;} = new List<DespachoProgramaDeComputador>();
        public virtual ICollection<Linguagem> Linguagens {get; set;} = new List<Linguagem>();

        public virtual ICollection<CampoDeAplicacao> CampoDeAplicacao {get; set;} = new List<CampoDeAplicacao>();

        public virtual ICollection<TipoPrograma> TiposDoPrograma {get; set;} = new List<TipoPrograma>();

    }

}
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
        [DisplayFormat(DataFormatString = "{0:dd/MMMMM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime Deposito {get; set;}

        [Display(Name = "Registro")]
        [DisplayFormat(DataFormatString = "{0:dd/MMMMM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime? Concessao {get; set;}

        [Column("titular")]
        public string Titular {get; set;} = "UNIVERSIDADE FEDERAL DE SERGIPE";

        public virtual ICollection<Inventor>? Inventores {get; set;} = new List<Inventor>();

        public virtual ICollection<DespachoProgramaDeComputador> Despachos {get; set;} = new List<DespachoProgramaDeComputador>();
        public virtual ICollection<Linguagem> Linguagens {get; set;} = new List<Linguagem>();
        public virtual ICollection<CampoDeAplicacao> CampoDeAplicacao {get; set;} = new List<CampoDeAplicacao>();
        public virtual ICollection<TipoPrograma> TiposDoPrograma {get; set;} = new List<TipoPrograma>();

    }

    [Table(name: "tipo_programa")]
    public class TipoPrograma
    {
        [Key]
        [Column("codigo")]
        public string Codigo {get; set;} = null!;

        [Column("descricao")]
        public string? Descricao {get; set;}

    }

    [Table(name: "linguagem")]
    public class Linguagem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id {get; set;}

        [Required (ErrorMessage = "Nome é Obrigatório")]
        [Column(name: "nome")]
        public string Nome {get; set;} = null!;
    }

    [Table("campo_de_aplicacao")]
    public class CampoDeAplicacao
    {
        [Key]
        [Column("codigo")]
        [Required (ErrorMessage = "Codigo é Obrigatório")]
        public string Codigo {get; set;} = null!;

        [Column("descricao")]
        public string? Descricao {get; set;}
    }

}
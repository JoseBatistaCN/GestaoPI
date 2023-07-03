using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GestaoPI.Interfaces;

namespace GestaoPI.Models
{
    [Table("codigo_despacho_programa_de_computador")]
    public class CodigoDespachoProgramaDeComputador : ICodigoDespacho
    {
        [Key]
        [Column("cod_despacho")]
        [StringLength(10)]
        public string Codigo {get; set;} = null!;

        [Column("titulo")]
        public string? Titulo {get; set;} = null!;

        [Column("descricao")]
        public string? Descricao {get; set;} = null!;

        [Column("prazo")]
        public int? Prazo {get; set;} = null!;

        public virtual ICollection<DespachoProgramaDeComputador> DespachoProgramasDeComputador { get; set;} = new List<DespachoProgramaDeComputador>();
    
    }
}
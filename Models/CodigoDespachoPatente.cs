using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GestaoPI.Interfaces;

namespace GestaoPI.Models
{
    [Table("codigo_despacho_patente")]
    public class CodigoDespachoPatente : ICodigoDespacho
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

        public virtual ICollection<DespachoPatente> DespachoPatentes { get; set;} = new List<DespachoPatente>();
    
    }
}
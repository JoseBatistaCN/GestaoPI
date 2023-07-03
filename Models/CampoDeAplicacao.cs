using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoPI.Models
{
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
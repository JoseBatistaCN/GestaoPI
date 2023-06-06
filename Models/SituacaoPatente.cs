using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GestaoPI.Models
{
    [Table("situacao_patente")]
    public class SituacaoPatente
    {
        [Key]
        [Column("situacao")]
        public string Situacao {get; set;} = null!;

        public ICollection<Patente> Patentes {get; set;} = new List<Patente>();
    }
}
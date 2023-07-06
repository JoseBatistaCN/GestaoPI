using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GestaoPI.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GestaoPI.Models
{
    [Table("anuidade")]
    public class Anuidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("ano")]
        [Range(3, 20)]
        public short Ano { get; set; }

        [Column("ordinario")]
        public DateTime Orinario { get; set; }

        [Column("extraordinario")]
        public DateTime Extraordinario { get; set; }

        public PagamentoAnuidade? PagamentoAnuidade { get; set; }

        public virtual Patente Patente { get; set; } = null!;
    }
}
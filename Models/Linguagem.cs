using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoPI.Models
{

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
}
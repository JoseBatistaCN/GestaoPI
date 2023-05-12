using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoPI.Models
{
    [Table("titular")]
    public class Titular
    {
        [Key]
        [Column("nome")]
        public string Nome {get; set;} = null!;
        
    }
}
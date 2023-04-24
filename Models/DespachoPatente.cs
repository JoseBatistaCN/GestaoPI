using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoPI.Models
{
    public class DespachoPatente
    {
        [Key]
        [Column("patente_codigo")]
        public String PatenteCodigo {get; set;}
        
    }
}
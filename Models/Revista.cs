using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GestaoPI.Models
{
    public class Revista
    {
        [Key]
        public ushort numeroRevista {get; set;}
        public DateTime dataPublicacao {get; set;}
    }
}
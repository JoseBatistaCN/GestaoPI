using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GestaoPI.Models
{
    public class Despacho
    {
        public int Revista {get; set;}
        public DateTime Publicacao {get; set;}
        public string CodigoDespacho {get; set;}
        public string Descricao {get; set;}
        public DateTime Vencimento {get; set;}
        public bool cumprido {get; set;}
    }
}
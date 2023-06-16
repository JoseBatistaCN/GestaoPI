using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoPI.Interfaces;

namespace GestaoPI.Models
{
    public abstract class Processo : IProcesso
    {
        public string Codigo {get; set;} = null!;
        public string? Titulo {get; set;}
        public DateTime Deposito {get; set;}
        public DateTime? Concessao {get; set;}
        public ICollection<IDespacho> Despachos {get; set;}
    }
}
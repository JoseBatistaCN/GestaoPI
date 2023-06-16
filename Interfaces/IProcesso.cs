using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoPI.Interfaces
{
    public interface IProcesso
    {
        public string Codigo {get; set;}
        public string? Titulo {get; set;}
        public DateTime Deposito {get; set;}
        public DateTime? Concessao {get; set;}
        public ICollection<IDespacho> Despachos {get; set;}

    }
}
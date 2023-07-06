using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoPI.Interfaces
{
    public interface ICodigoDespacho
    {
        public string Codigo {get;}
        public string Titulo {get;}
        public string? Descricao {get;}
        public int? Prazo {get;}
    }
}
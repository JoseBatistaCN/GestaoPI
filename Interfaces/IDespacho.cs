using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoPI.Interfaces
{
    public interface IDespacho
    {
        public int Id {get; set;}
        public ICodigoDespacho Codigo {get; set;}
        public IProcesso Processo {get; set;}
        public DateTime? Validade {get; set;}
        public Boolean? Cumprido {get; set;}
        public IRevista Revista {get; set;}
    }
}
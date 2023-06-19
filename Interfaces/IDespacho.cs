using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoPI.Interfaces
{
    public interface IDespacho
    {
        public int Id {get; set;}
        public string CodigoDespacho {get; set;}
        public string Processo {get; set;}
        public DateTime? validade {get;}
        public string CodigoRevista {get; set;}

    }
}
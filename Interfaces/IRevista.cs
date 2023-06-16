using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoPI.Interfaces
{
    public interface IRevista
    {
        public string Codigo {get; set;}
        public DateTime Data {get; set;}
        public ICollection<IDespacho> Despachos {get; set;}
    }
}
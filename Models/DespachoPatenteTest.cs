using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoPI.Interfaces;

namespace GestaoPI.Models
{
    public class DespachoPatenteTest : IDespacho
    {
        public int Id {get; set;}

        
        public DateTime? Validade {get; set;}
        public Boolean? Cumprido {get; set;}
        public Revista? Revista {get; set;}
        public Processo? Processo {get; set;}
    }
}
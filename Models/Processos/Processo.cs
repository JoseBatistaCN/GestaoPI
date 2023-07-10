using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoPI.Models.Processos
{
    public abstract class Processo
    {
        public virtual String Codigo { get; set; } = null!;
    }
}
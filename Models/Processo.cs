using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoPI.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace GestaoPI.Models
{
    public abstract class Processo : IProcesso
    {
        public string Codigo { get; set; } = null!;
        public DateTime Deposito { get; set;}
        public DateTime? Concessao { get; set; }
        public string? Titulo { get; set;}
    }
}
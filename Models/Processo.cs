using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoPI.Interfaces;

namespace GestaoPI.Models
{
    public class Processo : IProcesso
    {
        public string Codigo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime Deposito { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? Concessao { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? Titulo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
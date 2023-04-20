using System;
using System.Collections.Generic;

namespace GestaoPI.Models;

public partial class Servicospatente
{
    public int Codigo { get; set; }

    public string Servico { get; set; } = null!;

    public decimal? ValorSemDesconto { get; set; }

    public decimal? ValorComDesconto { get; set; }
}

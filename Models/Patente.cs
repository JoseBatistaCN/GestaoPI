using System;
using System.Collections.Generic;

namespace GestaoPI.Models;

public partial class Patente
{
    public string Codigo { get; set; } = null!;

    public string? Titulo { get; set; }

    public string? Resumo { get; set; }

    public string? Status { get; set; }

    public DateOnly Deposito { get; set; }

    public DateOnly? Concessao { get; set; }

    public DateOnly? Exame { get; set; }

    public DateOnly? Publicacao { get; set; }

    public string? Anotacao { get; set; }

    public string SituacaoPatenteSituacao { get; set; } = null!;
}

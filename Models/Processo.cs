using System;
using System.Collections.Generic;

namespace GestaoPI.Models;

public partial class Processo
{
    public string Tipo { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public string? Titulo { get; set; }

    public string? Resumo { get; set; }

    public DateOnly? Deposito { get; set; }

    public DateOnly? Exame { get; set; }

    public DateOnly? DominioPublico { get; set; }

    public string? Anotacao { get; set; }

    public string? CodigoNotificacao { get; set; }
}

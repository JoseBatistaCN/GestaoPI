using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestaoPI.Models;

public partial class Processo
{
    [Required]
    [StringLength(13)]
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

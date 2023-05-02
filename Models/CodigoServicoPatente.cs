using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestaoPI.Models;

[Table("codigoservicopatente")]
public partial class Codigoservicopatente
{
    [Key]
    public string Servico { get; set; } = null!;

    [Precision(10, 2)]
    public decimal? ValorSemDesconto { get; set; }

    [Precision(10, 2)]
    public decimal? ValorComDesconto { get; set; }
}

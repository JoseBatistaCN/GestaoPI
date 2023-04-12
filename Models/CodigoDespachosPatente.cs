using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestaoPI.Models;

[Table("codigo_despachos_patente")]
[Index("Descricao", Name = "descricao_UNIQUE", IsUnique = true)]
public partial class CodigoDespachosPatente
{
    [Key]
    [Column("codigo_id")]
    public string CodigoId { get; set; } = null!;

    [Column("descricao")]
    public string? Descricao { get; set; }

    [Column("cumprimento")]
    public int? Cumprimento { get; set; }
}

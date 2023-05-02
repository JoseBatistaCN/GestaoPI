using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestaoPI.Models;

[Table("codigodespachopatente")]
public partial class Codigodespachopatente
{
    [Key]
    public string Codigo { get; set; } = null!;

    [Column("descricao")]
    [StringLength(255)]
    public string? Descricao { get; set; }
}

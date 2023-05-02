using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestaoPI.Models;

[Table("patente")]
[Index("Codigo", Name = "codigo_UNIQUE", IsUnique = true)]
public partial class Patente
{
    [Key]
    [Column("codigo")]
    [StringLength(19)]
    public string Codigo { get; set; } = null!;

    [Column("titulo")]
    [StringLength(255)]
    public string? Titulo { get; set; }

    [Column("resumo", TypeName = "mediumtext")]
    public string? Resumo { get; set; }

    [Column("status")]
    [StringLength(45)]
    public string? Status { get; set; }

    [Column("deposito")]
    public DateTime Deposito { get; set; }

    [Column("concessao")]
    public DateTime? Concessao { get; set; }

    [Column("exame")]
    public DateTime? Exame { get; set; }

    [Column("publicacao")]
    public DateTime? Publicacao { get; set; }

    [Column("anotacao", TypeName = "text")]
    public string? Anotacao { get; set; }

    [InverseProperty("PatenteCodigoNavigation")]
    public virtual ICollection<Despachopatente> Despachopatentes { get; } = new List<Despachopatente>();

    [InverseProperty("PatenteCodigoNavigation")]
    public virtual ICollection<Servicopatente> Servicopatentes { get; } = new List<Servicopatente>();
}

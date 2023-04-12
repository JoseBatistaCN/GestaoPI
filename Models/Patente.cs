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
    [StringLength(20)]
    public string Codigo { get; set; } = null!;

    [Column("titulo")]
    [StringLength(255)]
    public string? Titulo { get; set; }

    [Column("resumo")]
    public string? Resumo { get; set; }

    [Column("situacao", TypeName = "enum('Em Processo','Concedido')")]
    public string? Situacao { get; set; }

    [Column("status")]
    [StringLength(45)]
    public string? Status { get; set; }

    [Column("deposito")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? Deposito { get; set; }

    [Column("concessao")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? Concessao { get; set; }

    [Column("exame")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? Exame { get; set; }

    [Column("dominio_publico")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? DominioPublico { get; set; }

    [Column("anotacao", TypeName = "text")]
    public string? Anotacao { get; set; }
}

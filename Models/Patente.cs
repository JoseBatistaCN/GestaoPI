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
    [Display(Name = "Código")]
    [StringLength(19)]
    [RegularExpression(@"^[A-Z]{2}\s[0-9]{2}\s[0-9]{4}\s[0-9]{6}\s[0-9]{1}$", ErrorMessage = "Formato Inválido")]
    public string Codigo { get; set; } = null!;

    [Column("titulo")]
    [Display(Name = "Título")]
    [StringLength(255)]
    public string? Titulo { get; set; }

    [Column("resumo")]
    [Display(Name ="Resumo")]
    public string? Resumo { get; set; }

    [Column("situacao", TypeName = "enum('Em Processo','Concedido')")]
    [Display(Name = "Situação")]
    public string? Situacao { get; set; }

    [Column("status")]
    [Display(Name = "Status")]
    [StringLength(45)]
    public string? Status { get; set; }

    [Column("deposito")]
    [Required]
    [Display(Name = "Depósito")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? Deposito { get; set; }

    [Column("concessao")]
    [Display(Name = "Concessão")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? Concessao { get; set; }

    [Column("exame")]
    [Display(Name = "Exame")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? Exame { get; set; }

    [Column("publicacao")]
    [Display(Name = "Publicação")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? Publicacao { get; set; }

    [Column("anotacao", TypeName = "text")]
    [Display(Name = "Anotação")]
    public string? Anotacao { get; set; }
}

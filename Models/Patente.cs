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
    [Display(Name = "Código INPI")]
    [RegularExpression(@"^[A-Z]{2}\s[0-9]{2}\s[0-9]{4}\s[0-9]{6}\s[0-9]$", ErrorMessage="Formato Inválido, BR ZZ XXXX YYYYYY K")]
    [Required(ErrorMessage = "Campo Obrigatório")]
    [StringLength(19)]
    public string Codigo { get; set; } = null!;

    [Column("titulo")]
    [Display(Name = "Título")]
    [StringLength(255)]
    public string? Titulo { get; set; }

    [Column("resumo", TypeName = "mediumtext")]
    public string? Resumo { get; set; }

    [Column("status")]
    [Display(Name = "Status")]
    [StringLength(45)]
    public string? Status { get; set; }

    [Column("deposito")]
    [Required(ErrorMessage = "Campo Obrigatório")]
    [Display(Name = "Depósito")]

    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
    public DateTime Deposito { get; set; }

    [Column("concessao")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
    public DateTime? Concessao { get; set; }

    [Column("exame")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
    public DateTime? Exame { get; set; }

    [Column("publicacao")]
    [Display(Name = "Publicação")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
    public DateTime? Publicacao { get; set; }

    [Column("anotacao", TypeName = "text")]
    [Display(Name = "Anotação")]
    public string? Anotacao { get; set; }

    [InverseProperty("PatenteCodigoNavigation")]
    public virtual ICollection<Despachopatente> Despachopatentes { get; } = new List<Despachopatente>();

    [InverseProperty("PatenteCodigoNavigation")]
    public virtual ICollection<Servicopatente> Servicopatentes { get; } = new List<Servicopatente>();

}

using System;
using System.Collections.Generic;
using GestaoPI.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using GestaoPI.Interfaces;

namespace GestaoPI.Models;

[Table("patente")]
[Index("Codigo", Name = "codigo_UNIQUE", IsUnique = true)]
public class Patente : IProcesso
{

    // Dados do Processo
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

    [Column("situacao")]
    [Display(Name = "Situação")]
    [Required(ErrorMessage = "Campo Obrigatório")]
    public PatenteSituacao Situacao { get; set; } = PatenteSituacao.EmAnalise;

    [Column("status")]
    [Display(Name = "Status")]
    public Boolean Status { get; set; } = true;

    // Datas do Processo

    [Column("deposito")]
    [Required(ErrorMessage = "Campo Obrigatório")]
    [Display(Name = "Depósito")]

    [DisplayFormat(DataFormatString = "{0:dd/MMMMM/yyyy}", ApplyFormatInEditMode = false)]
    public DateTime Deposito { get; set; }

    [Column("concessao")]
    [DisplayFormat(DataFormatString = "{0:dd/MMMMM/yyyy}", ApplyFormatInEditMode = false)]
    [Display(Name = "Concessão")]
    public DateTime? Concessao { get; set; }

    [Column("exame")]
    [DisplayFormat(DataFormatString = "{0:dd/MMMMM/yyyy}", ApplyFormatInEditMode = false)]
    public DateTime? Exame { get; set; }

    [Column("publicacao")]
    [Display(Name = "Publicação")]
    [DisplayFormat(DataFormatString = "{0:dd/MMMMM/yyyy}", ApplyFormatInEditMode = false)]
    public DateTime? Publicacao { get; set; }

    // Outros

    [Column("anotacao", TypeName = "text")]
    [Display(Name = "Anotação")]
    public string? Anotacao { get; set; }

    public virtual ICollection<Inventor> Inventores { get; set; } = new List<Inventor>();

    public virtual ICollection<DespachoPatente> DespachoPatentes { get; set; } = new List<DespachoPatente>();

    public virtual ICollection<Anuidade> Anuidades { get; set; } = new List<Anuidade>();

}

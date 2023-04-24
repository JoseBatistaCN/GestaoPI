using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestaoPI.Models;

public partial class Patente
{
    [Key]
    [Required]
    [StringLength(19)]
    [Display(Name = "Código")]
    [RegularExpression(@"^[A-Z]{2}\s[0-9]{2}\s[0-9]{4}\s[0-9]{6}\s[0-9]$")]
    public string Codigo { get; set; } = null!;

    [Display(Name = "Título")]
    public string? Titulo { get; set; }

    public string? Resumo { get; set; }

    public string? Status { get; set; }

    [Display(Name = "Depósito")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
    public DateTime Deposito { get; set; }

    [Display(Name = "Concessão")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
    public DateTime? Concessao { get; set; }

    [Display(Name = "Exame")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
    public DateTime? Exame { get; set; }

    [Display(Name = "Publicação")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
    public DateTime? Publicacao { get; set; }

    [Display(Name = "Anotação")]
    public string? Anotacao { get; set; }

    public ICollection<ServicoPatente> Servicos => new List<ServicoPatente>();
    public ICollection<DespachoPatente> Despachos => new List<DespachoPatente>();
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestaoPI.Models;

[Table("servico_patente")]
public class ServicoPatente
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("cod_patente")]
    [StringLength(19)]
    public string CodigoPatente { get; set; } = null!;

    [Column("cod_servico_patente")]
    [Display(Name = "Código")]
    public string CodigoServico {get; set;} = null!;

    [Column("valor")]
    [Precision(10, 2)]
    public decimal? Valor { get; set; }

    [Column("protocolo")]
    [RegularExpression(@"[0-9]*")]
    public string? Protocolo {get; set;}

    [Column("dt_servico")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
    public DateTime? Data {get; set;} = DateTime.Now;

    [ForeignKey("CodigoServico")]
    [Display(Name = "Serviço")]
    public virtual CodigoServicoPatente CodigoServicoPatente {get; set;} = null!;

    [ForeignKey("CodigoPatente")]
    [Display(Name = "Código INPI")]
    public virtual Patente Patente { get; set; } = null!;

}

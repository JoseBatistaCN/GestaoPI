using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestaoPI.Models;

[Table("servico_patente")]
public class ServicoPatente : Servico
{
    [Key]
    [Column("id_servico_patente")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ServicoPatenteId { get; set; }

    [Column("patente_codigo")]
    [StringLength(19)]
    public string PatenteCodigo { get; set; } = null!;

    [Column("codigo_servico_patente")]
    public string ServicoCodigo {get; set;} = null!;

    [Column("valor")]
    [Precision(10, 2)]
    public decimal? Valor { get; set; }

    [Column("protocolo")]
    [RegularExpression(@"[0-9]*")]
    public string? Protocolo {get; set;}

    [Column("data")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
    public DateTime? Data {get; set;} = DateTime.Now;

    [ForeignKey("ServicoCodigo")]
    [Display(Name = "Serviço")]
    public virtual CodigoServicoPatente CodigoServicoPatente {get; set;} = null!;

    [ForeignKey("PatenteCodigo")]
    [Display(Name = "Código INPI")]
    public virtual Patente Patente { get; set; } = null!;

}

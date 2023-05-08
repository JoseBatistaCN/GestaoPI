using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestaoPI.Models;

[Table("servicopatente")]
[Index("PatenteCodigo", Name = "fk_ServicoPatente_patente1_idx")]
public partial class Servicopatente
{
    [Key]
    [Column("servicoPatente_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ServicoPatenteId { get; set; }

    [Column("patente_codigo")]
    [StringLength(19)]
    public string PatenteCodigo { get; set; } = null!;

    [Column("codigo_servico_patente")]
    public string ServicoCodigo {get; set;} = null!;

    [Precision(10, 2)]
    public decimal? Valor { get; set; }

    [ForeignKey("ServicoCodigo")]
    public virtual Codigoservicopatente CodigoservicopatenteNavigation {get; set;} = null!;


    [ForeignKey("PatenteCodigo")]
    public virtual Patente PatenteCodigoNavigation { get; set; } = null!;
}

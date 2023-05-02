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
    public int ServicoPatenteId { get; set; }

    [Column("patente_codigo")]
    [StringLength(19)]
    public string PatenteCodigo { get; set; } = null!;

    [Precision(10, 2)]
    public decimal? Valor { get; set; }

    [ForeignKey("PatenteCodigo")]
    [InverseProperty("Servicopatentes")]
    public virtual Patente PatenteCodigoNavigation { get; set; } = null!;
}

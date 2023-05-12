using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestaoPI.Models;

[PrimaryKey("PatenteCodigo", "RevistaCodigo")]
[Table("despacho_patente")]
public partial class DespachoPatente
{
    [Key]
    [Column("patente_codigo")]
    [StringLength(19)]
    public string PatenteCodigo { get; set; } = null!;

    [Key]
    [Column("revista_codigo")]
    public int RevistaCodigo { get; set; }

    [Column("codigo_despacho")]
    public string CodigoDespacho { get; set; } = null!;

    [StringLength(255)]
    public string? Descricao { get; set; }

    [Column("validade")]
    public DateTime? Validade { get; set; }

    [Column("cumprido")]
    public Boolean? Cumprido { get; set; }

    [ForeignKey("CodigoDespacho")]
    public virtual CodigoDespachoPatente CodigoDespachoPatenteNavigation { get; set; } = null!;

    [ForeignKey("PatenteCodigo")]
    public virtual Patente PatenteCodigoNavigation { get; set; } = null!;

    [ForeignKey("RevistaCodigo")]
    public virtual Revista  RevistaCodigoNavigation { get; set; } = null!;
}

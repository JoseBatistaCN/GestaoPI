using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestaoPI.Models;

[PrimaryKey("PatenteCodigo", "RevistaCodigo")]
[Table("despachopatente")]
[Index("CodigoDespachosPatenteCodigo", Name = "fk_DespachoPatente_CodigoDespachosPatente1_idx")]
[Index("PatenteCodigo", Name = "fk_DespachoPatente_patente1_idx")]
[Index("RevistaCodigo", Name = "fk_DespachoPatente_revista1_idx")]
public partial class Despachopatente
{
    [Key]
    [Column("patente_codigo")]
    [StringLength(19)]
    public string PatenteCodigo { get; set; } = null!;

    [Key]
    [Column("revista_codigo")]
    public int RevistaCodigo { get; set; }

    [Column("CodigoDespachosPatente_Codigo")]
    public string CodigoDespachosPatenteCodigo { get; set; } = null!;

    [StringLength(255)]
    public string? Descricao { get; set; }

    [Column("validade_codigo")]
    public DateTime? ValidadeCodigo { get; set; }

    [Column("cumprido")]
    public Boolean? Cumprido { get; set; }

    [ForeignKey("CodigoDespachosPatenteCodigo")]
    [InverseProperty("Despachopatentes")]
    public virtual Codigodespachospatente CodigoDespachosPatenteCodigoNavigation { get; set; } = null!;

    [ForeignKey("PatenteCodigo")]
    [InverseProperty("Despachopatentes")]
    public virtual Patente PatenteCodigoNavigation { get; set; } = null!;

    [ForeignKey("RevistaCodigo")]
    [InverseProperty("Despachopatentes")]
    public virtual Revista  RevistaCodigoNavigation { get; set; } = null!;
}

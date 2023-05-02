using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestaoPI.Models;

[Table("codigodespachospatente")]
public partial class Codigodespachospatente
{
    [Key]
    public string Codigo { get; set; } = null!;

    [Column("descricao")]
    [StringLength(255)]
    public string? Descricao { get; set; }

    [InverseProperty("CodigoDespachosPatenteCodigoNavigation")]
    public virtual ICollection<Despachopatente> Despachopatentes { get; } = new List<Despachopatente>();
}

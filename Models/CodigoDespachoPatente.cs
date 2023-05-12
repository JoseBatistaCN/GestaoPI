using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestaoPI.Models;

[Table("codigo_despacho_patente")]
public partial class CodigoDespachoPatente
{
    [Key]
    [Column("codigo_despacho")]
    public string CodigoDespacho { get; set; } = null!;

    [Column("descricao")]
    [StringLength(255)]
    public string? Descricao { get; set; }

    [InverseProperty("CodigoDespachoPatenteNavigation")]
    public ICollection<DespachoPatente> DespachosPatente {get; set;} = new List<DespachoPatente>();

}

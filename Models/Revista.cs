using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestaoPI.Models;

[Table("revista")]
public partial class Revista
{
    [Key]
    [Column("codigo")]
    public int Codigo { get; set; }

    [Column("data")]
    public DateTime Data { get; set; }

    [Column("DespachoPatente_patente_codigo")]
    [StringLength(19)]
    public string DespachoPatentePatenteCodigo { get; set; } = null!;

    [InverseProperty("RevistaCodigoNavigation")]
    public virtual ICollection<Despachopatente> Despachopatentes { get; } = new List<Despachopatente>();
}

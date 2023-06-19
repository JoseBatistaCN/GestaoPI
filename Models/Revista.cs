using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestaoPI.Models;

[Table("revista")]
public class Revista
{
    [Key]
    [Column("cod_revista")]
    public string Codigo { get; set; } = null!;

    [Column("dt_revista")]
    public DateTime Data { get; set; }

    public virtual ICollection<DespachoPatente> DespachoPatentes { get; } = new List<DespachoPatente>();
}

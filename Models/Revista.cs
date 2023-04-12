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
    public DateOnly Data { get; set; }
}

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
    [Column("nm_revista")]
    public string Numero { get; set; } = null!;

    [Column("dt_publicacao")]
    public DateTime DataPublicacao { get; set; }

    public virtual ICollection<DespachoPatente> DespachoPatentes { get; set;} = new List<DespachoPatente>();
    public virtual ICollection<DespachoMarca> DespachosMarcas { get; set;} = new List<DespachoMarca>();
    public virtual ICollection<DespachoProgramaDeComputador> DespachoProgramaDeComputadors { get; set;} = new List<DespachoProgramaDeComputador>();

    

}

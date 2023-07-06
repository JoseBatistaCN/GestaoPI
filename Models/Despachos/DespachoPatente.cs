using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GestaoPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using GestaoPI.Models;

namespace GestaoPI.Models;

[Table("despacho_patente")]
public class DespachoPatente
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("cod")]
    [Display(Name = "Código")]
    public string Codigo {get; set;} = null!;

    [Column("cod_patente")]
    public string Processo { get ; set; } = null!;

    [Column("validade")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
    public DateTime? validade {get;}

    [Column("nm_revista")]
    public string NumeroRevista { get; set; } = null!;

    [ForeignKey("Processo")]
    public virtual Patente Patente { get; set; } = null!;
    
    [ForeignKey("NumeroRevista")]
    public virtual Revista Revista {get; set;} = null!;

    [ForeignKey("Codigo")]
    public virtual CodigoDespachoPatente CodigoDespachoPatente {get; set;} = null!;

    
}
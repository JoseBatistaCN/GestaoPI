using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GestaoPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using GestaoPI.Models;

namespace GestaoPI.Models;

[Table("despacho_marca")]
public class DespachoMarca : IDespacho
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("cod_despacho")]
    [Display(Name = "Código")]
    public string CodigoDespacho {get; set;} = null!;

    [Column("cod_marca")]
    public string Processo { get ; set; } = null!;

    [Column("validade")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
    public DateTime? validade {get;}

    [Column("cod_revista")]
    public string CodigoRevista { get; set; } = null!;

    [ForeignKey("Processo")]
    public virtual Marca Marca { get; set; } = null!;
    
    [ForeignKey("CodigoRevista")]
    public virtual Revista Revista {get; set;} = null!;

    [ForeignKey("CodigoDespacho")]
    public virtual CodigoDespachoMarca CodigoDespachoMarca {get; set;} = null!;

    
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestaoPI.Models;

[Table("codigo_servico_patente")]
public partial class CodigoServicoPatente
{
    [Key]
    [Column("cod_servico")]
    [StringLength(10)]
    public string Codigo { get; set; } = null!;

    [Column("servico")]
    [Display(Name = "Serviço")]
    public string Servico {get; set;} = null!;    

    [Precision(10, 2)]
    [Column("valor_sem_desconto")]
    [Display(Name = "Valor sem desconto")]
    public decimal? ValorSemDesconto { get; set; }

    [Precision(10, 2)]
    [Column("valor_com_desconto")]
    [Display(Name = "Valor com desconto")]
    public decimal? ValorComDesconto { get; set; }
    
    public ICollection<ServicoPatente> ServicosPatente {get; set;} = new List<ServicoPatente>();

}

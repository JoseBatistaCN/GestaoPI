using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoPI.Models
{
    [Table("programa_de_computador")]
    public class ProgramaDeComputador
    {
        [Key]
        [Column("codigo")]
        [Display(Name = "Nº do Pedido")]
        public string Codigo {get; set;} = null!;

        [Column("titulo")]
        [Display(Name = "Título")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string? Titulo {get; set;}

        [Column("data_deposito")]
        [Display(Name = "Depósito")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public DateTime Deposito {get; set;}

        [Column("data_registro")]
        [Display(Name = "Registro")]
        public DateTime? Registro {get; set;}



    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoPI.Models
{
    [Table("desenho_industrial")]
    public class DesenhoIndustrial : Processo
    {
        [Key]
        [Column("codigo")]
        [Display(Name = "Nº do Pedido")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Codigo {get; set;} = null!;

        [Column("titulo")]
        [Display(Name = "Título")]
        [Required(ErrorMessage = "Título é Obrigatório")]
        public string Titulo {get; set;} = null!;

        [Column("data_deposito")]
        [Display(Name = "Depósito")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public DateTime Deposito {get; set;}

        
    }
}
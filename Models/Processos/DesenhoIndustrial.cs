using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoPI.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoPI.Models
{
    [Table("desenho_industrial")]
    public class DesenhoIndustrial : IProcesso
    {
        [Key]
        [Column("cod_desenho_industrial")]
        [Required(ErrorMessage = "O código do desenho industrial é obrigatório.")]
        public string Codigo {get; set;} = null!;

        [Column("titulo")]
        [Display(Name = "Título")]
        public string? Titulo {get; set;}

        [Column("deposito")]
        [Display(Name = "Depósito")]
        public DateTime Deposito {get; set;}

        [Column("concessao")]
        [Display(Name = "Concessão")]
        public DateTime? Concessao {get; set;}
        public virtual ICollection<Inventor> Inventores {get; set;} = new List<Inventor>();

    }
}
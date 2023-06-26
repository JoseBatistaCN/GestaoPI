using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GestaoPI.Models.Enums;
using GestaoPI.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoPI.Models
{
    [Table("marca")]
    public class Marca : IProcesso
    {
        [Key]
        [Column("cod_marca")]
        [Display(Name = "Número")]
        [Required (ErrorMessage = "O código da marca é obrigatório.")]
        public string Codigo {get; set;} = null!;

        [Column("marca")]
        [Required (ErrorMessage = "O nome da marca é obrigatório.")]
        [Display(Name = "Marca")]
        public string? Titulo {get; set;}

        [Column("apresentacao")]
        [Display(Name = "Apresentação")]
        public MarcaApresentacao? Apresentacao {get; set;}

        [Column("situacao")]
        [Display(Name = "Situação")]
        public MarcaSituacao? Situacao {get; set;}

        [Column("deposito")]
        [Required (ErrorMessage = "O nome do titular é obrigatório.")]
        [Display(Name = "Depósito")]
        public DateTime Deposito {get; set;}

        [Column("concessao")]
        [Display(Name = "Concessão")]
        public DateTime? Concessao {get; set;}

        [Column("anotacao")]
        [Display(Name = "Anotação")]
        public string? Anotacao {get; set;}

        [Column("status")]
        [Display(Name = "Status")]
        public Boolean Status {get; set;} = true;
        
        public virtual ICollection<Inventor>? Inventores {get; set;} = new List<Inventor>();
        
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GestaoPI.Models.Enums;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoPI.Models
{
    [Table("marca")]
    public class Marca
    {

        [Key]
        [Column("codigo")]
        [Display(Name = "Código INPI")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [RegularExpression("[0-9]{9}$", ErrorMessage = "Somente 9 números")]
        [StringLength(9)]
        public string NumeroProcesso {get; set;} = null!;

        [Column("marca")]
        [Display(Name = "Marca")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string NomeMarca {get; set;} = null!;

        [Column("apresentacao")]
        [Display(Name = "Apresentação")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public MarcaApresentacao Classe {get; set;} = MarcaApresentacao.Nominativa;


        [Column("situacao")]
        [Display(Name = "Situação")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public MarcaSituacao Situacao {get; set;} = MarcaSituacao.Publicado;
    }
}
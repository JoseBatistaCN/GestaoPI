using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [RegularExpression("[0-9]*$", ErrorMessage = "Somente números")]
        [StringLength(9)]
        
        public string NumeroProcesso {get; set;} = null!;

        [Column("marca")]
        [Display(Name = "Marca")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string NomeMarca {get; set;} = null!;


    
    // Publicado, Arquivado, Indeferido, Concedido, Aguardando Sobrestamento, Extinto, 
    public enum SitaucacaoMarca
    {
        Publicado, 
        Aruivado,
        Indeferido,
        Concedido,
        
    }

    }
}
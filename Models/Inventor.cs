using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoPI.Models
{
    [Table("inventor")]
    public class Inventor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InventorID {get; set;}

        [Column("nome")]
        [RegularExpression(@"^[A-Z][a-z]+(\s[A-Z][a-z]+)+$", ErrorMessage="Nome Inválido")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Nome {get; set;} = null!;


        public ICollection<Patente> Patentes {get; set;} = new List<Patente>();
        public ICollection<Marca> Marcas {get; set;} = new List<Marca>();
        public ICollection<ProgramaDeComputador> ProgramasDeComputador {get; set;} = new List<ProgramaDeComputador>();
        public ICollection<DesenhoIndustrial> DesenhosIndustriais {get; set;} = new List<DesenhoIndustrial>();

    }
}
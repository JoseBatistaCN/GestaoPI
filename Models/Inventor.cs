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
        [Column("id")]
        public int Id {get; set;}

        [Column("nm_inventor")]
        [Required (ErrorMessage = "O nome do inventor é obrigatório.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome do inventor.")]
        public string Nome {get; set;} = null!;

        public virtual ICollection<Patente> Patentes { get; set;} = new List<Patente>();

    }
}
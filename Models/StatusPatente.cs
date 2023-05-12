using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GestaoPI.Models
{
    [Table("status_patente")]
    public class StatusPatente
    {
        [Key]
        [Column("status")]
        public string Status {get; set;} = null!;

        [InverseProperty("StatusPatenteNavigation")]
        public ICollection<Patente> Patentes {get; set;} = new List<Patente>();
    }
}
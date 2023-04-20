using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GestaoPI.Models
{
    public class Servico
    {
        [Required]
        [Display(Name = "Serviço")]
        public string TipoServico {get; set;}
        [Display(Name = "Valor")]
        public float Valor {get; set;}
        [Display(Name = "Dados do Serviço")]
        public string Descricao {get; set;}

    }
}
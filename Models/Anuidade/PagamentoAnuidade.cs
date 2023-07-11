using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoPI.Models
{
    [Table("pagamento_anuidade")]
    public class PagamentoAnuidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("dt_pagamento")]
        [Display(Name = "Data do Pagamento")]
        public DateTime? DataPagamento { get; set; }

        [Column("nm_protocolo")]
        [Display(Name = "Número do Protocolo")]
        public string? NumeroProtocolo { get; set; }

        [Column("vl_pago")]
        [Display(Name = "Valor")]
        public decimal? ValorPago { get; set; }

        [Column("anotacao")]
        [Display(Name = "Anotação")]
        public string? Anotacao { get; set; }

        [Column("pago")]
        [Display(Name = "Pago")]
        public bool Pago { get; set; } = false;

        
    }
}
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
        public DateTime DataPagamento { get; set; }

        [Column("nm_protocolo")]
        public string? NumeroProtocolo { get; set; }

        [Column("vl_pago")]
        public decimal ValorPago { get; set; }

        [Column("anotacao")]
        public string? Anotacao { get; set; }
    }
}
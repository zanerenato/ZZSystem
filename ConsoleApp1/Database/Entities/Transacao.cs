using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("Transacoes")]
    public class Transacao
    {
        [Key]
        [Column("TransacaoId")]
        [Required]
        public long TransacaoId { get; set; }
        [Column("Descricao")]
        [MaxLength]
        public string Descricao { get; set; }
        [Column("TipoTransacaoId")]
        [Required]
        public int TipoTransacaoId { get; set; }
        [Column("ContaId")]
        [Required]
        public long ContaId { get; set; }
        [Column("TipoDespesaId")]
        [Required]
        public int TipoDespesaId { get; set; }
        [Column("DataId")]
        [Required]
        public long DataId { get; set; }
        [Column("Baixado")]
        public bool? Baixado { get; set; }
        [Column("Valor")]
        public decimal? Valor { get; set; }
        [Column("Saldo")]
        public decimal? Saldo { get; set; }

        [ForeignKey("TipoTransacaoId")]
        public TipoTransacao TipoTransacao { get; set; }
        [ForeignKey("ContaId")]
        public Conta Conta { get; set; }
        [ForeignKey("TipoDespesaId")]
        public TipoDespesa TipoDespesa { get; set; }
        [ForeignKey("DataId")]
        public Data Data { get; set; }
    }

}

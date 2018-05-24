using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("Salarios")]
    public class Salario
    {
        [Key]
        [Column("SalarioId")]
        [Required]
        public long SalarioId { get; set; }
        [Column("ColaboradorId")]
        [Required]
        public long ColaboradorId { get; set; }
        [Column("TipoSalarioId")]
        [Required]
        public int TipoSalarioId { get; set; }
        [Column("TransacaoId")]
        [Required]
        public long TransacaoId { get; set; }
        [Column("Horas")]
        public decimal? Horas { get; set; }
        [Column("Horas60")]
        public decimal? Horas60 { get; set; }
        [Column("Horas100")]
        public decimal? Horas100 { get; set; }
        [Column("Encargos")]
        public decimal? Encargos { get; set; }
        [Column("Observacoes")]
        [MaxLength]
        public string Observacoes { get; set; }

        [ForeignKey("ColaboradorId")]
        public Colaborador Colaborador { get; set; }
        [ForeignKey("TipoSalarioId")]
        public TipoServico TipoServico { get; set; }
        [ForeignKey("TransacaoId")]
        public Transacao Transacao { get; set; }
    }

}

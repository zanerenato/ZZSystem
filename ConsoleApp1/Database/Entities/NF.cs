using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("NFs")]
    public class NF
    {
        [Key]
        [Column("NFId")]
        [Required]
        public int NFId { get; set; }
        [Column("ClienteId")]
        [Required]
        public long ClienteId { get; set; }
        [Column("OrcamentoId")]
        public long? OrcamentoId { get; set; }
        [Column("OrdemServicoId")]
        public long? OrdemServicoId { get; set; }
        [Column("Aliquota")]
        public decimal? Aliquota { get; set; }
        [Column("Descricao")]
        [MaxLength]
        public string Descricao { get; set; }
        [Column("DataEmissaoId")]
        [Required]
        public long DataEmissaoId { get; set; }
        [Column("ValorBruto")]
        [Required]
        public decimal ValorBruto { get; set; }
        [Column("ValorLiquido")]
        [Required]
        public decimal ValorLiquido { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }
        [ForeignKey("OrcamentoId")]
        public Orcamento Orcamento { get; set; }
        [ForeignKey("OrdemServicoId")]
        public OrdemServico OS { get; set; }
        [ForeignKey("DataEmissaoId")]
        public Data DataEmissao { get; set; }

        [InverseProperty("NF")]
        public List<ContaReceber> ContasReceber { get; set; }
    }

}

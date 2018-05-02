using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("ServicosOrcamentos")]
    public class ServicoOrcamento
    {
        [Key]
        [Column("ServicoOrcamentoId")]
        [Required]
        public long ServicoOrcamentoId { get; set; }
        [Column("ServicoId")]
        [Required]
        public long ServicoId { get; set; }
        [Column("OrcamentoId")]
        [Required]
        public long OrcamentoId { get; set; }
        [Column("Quantidade")]
        public int? Quantidade { get; set; }

        [ForeignKey("ServicoId")]
        public Servico Servico { get; set; }
        [ForeignKey("OrcamentoId")]
        public Orcamento Orcamento { get; set; }
    }

}

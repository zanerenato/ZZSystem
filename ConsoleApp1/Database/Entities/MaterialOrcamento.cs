using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("MateriaisOrcamentos")]
    public class MaterialOrcamento
    {
        [Key]
        [Column("MaterialOrcamentoId")]
        [Required]
        public long MaterialOrcamentoId { get; set; }
        [Column("OrcamentoId")]
        [Required]
        public long OrcamentoId { get; set; }
        [Column("ProdutoId")]
        [Required]
        public long ProdutoId { get; set; }

        [ForeignKey("OrcamentoId")]
        public Orcamento Orcamento { get; set; }
        [ForeignKey("ProdutoId")]
        public Produto Produto { get; set; }
    }

}

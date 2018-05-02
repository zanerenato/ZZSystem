using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("Servicos")]
    public class Servico
    {

        [Key]
        [Column("ServicoId")]
        [Required]
        public long ServicoId { get; set; }
        [Column("TipoDespesaId")]
        [Required]
        public int TipoDespesaId { get; set; }
        [Column("Descricao")]
        [MaxLength]
        public string Descricao { get; set; }
        [Column("Custo")]
        public decimal? Custo { get; set; }
        [Column("TipoServicoId")]
        [Required]
        public int TipoServicoId { get; set; }

        [ForeignKey("TipoDespesaId")]
        public TipoServico TipoDespesa { get; set; }
        [ForeignKey("TipoCustoId")]
        public TipoServico TipoServico { get; set; }

        public List<MaterialServico> MaterialServicos { get; set; }
        public List<Produto> Produtos { get; set; }

        public Servico()
        {
            MaterialServicos = new List<MaterialServico>();
            Produtos = new List<Produto>();
        }

    }

}

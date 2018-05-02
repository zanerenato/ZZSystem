using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("Estoques")]
    public class Estoque
    {
        [Key]
        [Column("EstoqueId")]
        [Required]
        public long EstoqueId { get; set; }
        [Column("CompraId")]
        public long? CompraId { get; set; }
        [Column("OSId")]
        public long? OSId { get; set; }
        [Column("DepositoEstoqueId")]
        [Required]
        public long DepositoEstoqueId { get; set; }
        [Column("ProdutoId")]
        [Required]
        public long ProdutoId { get; set; }
        [Column("TipoTransacaoId")]
        [Required]
        public int TipoTransacaoId { get; set; }
        [Column("DataId")]
        [Required]
        public long DataId { get; set; }
        [Column("Quantidade")]
        public decimal? Quantidade { get; set; }
        [Column("Saldo")]
        public decimal? Saldo { get; set; }


        [ForeignKey("OSId")]
        public OrdemServico OS { get; set; }
        [ForeignKey("CompraId")]
        public Compra Compra { get; set; }
        [ForeignKey("DepositoEstoqueId")]
        public DepositoEstoque DepositoEstoque { get; set; }
        [ForeignKey("ProdutoId")]
        public Produto Produto { get; set; }
        [ForeignKey("TipoTransacaoId")]
        public TipoTransacao TipoTransacao { get; set; }
        [ForeignKey("DataId")]
        public Data Data { get; set; }

    }

}

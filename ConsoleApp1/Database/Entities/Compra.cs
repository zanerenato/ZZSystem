using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("Compras")]
    public class Compra
    {
        [Key]
        [Column("CompraId")]
        [Required]
        public long CompraId { get; set; }
        [Column("NF")]
        public int? NF { get; set; }
        [Column("Descricao")]
        [MaxLength]
        public string Descricao { get; set; }
        [Column("FornecedorId")]
        public long? FornecedorId { get; set; }
        [Column("DataCompraId")]
        [Required]
        public long DataCompraId { get; set; }

        [ForeignKey("FornecedorId")]
        public Fornecedor Fornecedor { get; set; }
        [ForeignKey("DataCompraId")]
        public Data DataCompra { get; set; }

        [InverseProperty("Compra")]
        public List<Estoque> Estoques { get; set; }
        [InverseProperty("Compra")]
        public List<ContaPagar> ContasPagar { get; set; }
    }

}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("MateriaisServicos")]
    public class MaterialServico
    {
        [Key]
        [Column("MaterialServicoId")]
        [Required]
        public long MaterialServicoId { get; set; }
        [Column("ServicoId")]
        [Required]
        public long ServicoId { get; set; }
        [Column("ProdutoId")]
        [Required]
        public long ProdutoId { get; set; }
        [Column("Quantidade")]
        public decimal? Quantidade { get; set; }

        [ForeignKey("ServicoId")]
        public Servico Servico { get; set; }
        [ForeignKey("ProdutoId")]
        public Produto Produto { get; set; }
    }

}

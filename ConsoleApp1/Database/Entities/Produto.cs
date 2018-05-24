using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        [Column("ProdutoId")]
        [Required]
        public long ProdutoId { get; set; }
        [Column("Descricao")]
        [MaxLength]
        public string Descricao { get; set; }
        [Column("Altura")]
        public decimal? Altura { get; set; }
        [Column("Largura")]
        public decimal? Largura { get; set; }
        [Column("Comprimento")]
        public decimal? Comprimento { get; set; }
        [Column("Peso")]
        public decimal? Peso { get; set; }
        [Column("Unidade")]
        [MaxLength]
        public string Unidade { get; set; }
        [Column("Especificacoes")]
        [MaxLength]
        public string Especificacoes { get; set; }
    }

}

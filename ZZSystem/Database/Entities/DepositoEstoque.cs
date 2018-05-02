using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("DepositosEstoques")]
    public class DepositoEstoque
    {
        [Key]
        [Column("DepositoEstoqueId")]
        [Required]
        public long DepositoEstoqueId { get; set; }
        [Column("Descricao")]
        public long? Descricao { get; set; }
    }
}

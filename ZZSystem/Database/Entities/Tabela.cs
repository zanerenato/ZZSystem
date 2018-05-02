using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("Tabelas")]
    public class Tabela
    {
        [Key]
        [Column("TabelaId")]
        [Required]
        public int TabelaId { get; set; }
        [Column("Nome")]
        [Required]
        [MaxLength]
        public string Nome { get; set; }
    }

}

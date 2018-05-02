using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("TiposManutencoes")]
    public class TipoManutencao
    {
        [Key]
        [Column("TipoManutencaoId")]
        [Required]
        public int TipoManutencaoId { get; set; }
        [Column("Descricao")]
        [MaxLength]
        public string Descricao { get; set; }
    }

}

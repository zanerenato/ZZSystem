using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("TiposMaquinas")]
    public class TipoMaquina
    {
        [Key]
        [Column("TipoMaquinaId")]
        [Required]
        public int TipoMaquinaId { get; set; }
        [Column("Descricao")]
        [MaxLength]
        public string Descricao { get; set; }
    }
}

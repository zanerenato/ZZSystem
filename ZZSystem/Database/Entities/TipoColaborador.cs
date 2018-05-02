using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("TiposColaboradores")]
    public class TipoColaborador
    {
        [Key]
        [Column("TipoColaboradorId")]
        [Required]
        public int TipoColaboradorId { get; set; }
        [Column("Descricao")]
        [MaxLength]
        public string Descricao { get; set; }
    }

}

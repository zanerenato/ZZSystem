using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("TiposContas")]
    public class TipoConta
    {
        [Key]
        [Column("TipoContaId")]
        [Required]
        public int TipoContaId { get; set; }
        [Column("Descricao")]
        [MaxLength]
        public string Descricao { get; set; }
    }

}

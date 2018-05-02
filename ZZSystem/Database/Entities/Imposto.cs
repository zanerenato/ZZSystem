using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("Impostos")]
    public class Imposto
    {
        [Key]
        [Column("ImpostoId")]
        [Required]
        public long ImpostoId { get; set; }
        [Column("Descricao")]
        [MaxLength]
        public string Descricao { get; set; }
        [Column("Percentual")]
        public decimal? Percentual { get; set; }
    }

}

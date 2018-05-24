using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("TiposSalarios")]
    public class TipoSalario
    {
        [Key]
        [Column("TipoSalarioId")]
        [Required]
        public int TipoSalarioId { get; set; }
        [Column("Descricao")]
        [MaxLength]
        public string Descricao { get; set; }
    }

}

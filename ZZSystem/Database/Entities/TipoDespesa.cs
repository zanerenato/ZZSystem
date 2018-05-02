using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("TiposDespesas")]
    public class TipoDespesa
    {
        [Key]
        [Column("TipoDespesaId")]
        [Required]
        public int TipoDespesaId { get; set; }
        [Column("Descricao")]
        [MaxLength]
        public string Descricao { get; set; }
    }

}

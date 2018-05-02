using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("TiposTransacoes")]
    public class TipoTransacao
    {
        [Key]
        [Column("TipoTransacaoId")]
        [Required]
        public int TipoTransacaoId { get; set; }
        [Column("Descricao")]
        [MaxLength]
        public string Descricao { get; set; }
    }

}

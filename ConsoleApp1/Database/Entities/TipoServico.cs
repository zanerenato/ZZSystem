using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("TiposServicos")]
    public class TipoServico
    {
        [Key]
        [Column("TipoServicoId")]
        [Required]
        public int TipoServicoId { get; set; }
        [Column("Descricao")]
        [MaxLength]
        public string Descricao { get; set; }
    }

}

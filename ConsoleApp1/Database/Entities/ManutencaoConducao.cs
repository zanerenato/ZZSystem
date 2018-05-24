using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("ManutencoesConducoes")]
    public class ManutencaoConducao
    {
        [Key]
        [Column("ManutencaoConducaoId")]
        [Required]
        public long ManutencaoConducaoId { get; set; }
        [Column("ManutencaoId")]
        [Required]
        public long ManutencaoId { get; set; }
        [Column("ConducaoId")]
        [Required]
        public long ConducaoId { get; set; }

        [ForeignKey("ManutencaoId")]
        public Manutencao Manutencao { get; set; }
        [ForeignKey("ConducaoId")]
        public Conducao Conducao { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("Manutencoes")]
    public class Manutencao
    {
        [Key]
        [Column("ManutencaoId")]
        [Required]
        public long ManutencaoId { get; set; }
        [Column("CompraId")]
        [Required]
        public long CompraId { get; set; }
        [Column("TipoManutencaoId")]
        [Required]
        public int TipoManutencaoId { get; set; }
        [Column("DescricaoDefeito")]
        [MaxLength]
        public string DescricaoDefeito { get; set; }
        [Column("DescricaoManutencao")]
        [MaxLength]
        public string DescricaoManutencao { get; set; }

        [ForeignKey("CompraId")]
        public Compra Compra { get; set; }
        [ForeignKey("TipoManutencaoId")]
        public TipoManutencao TipoManutencao { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("ColaboradoresOS")]
    public class ColaboradorOS
    {
        [Key]
        [Column("ColadoradorOSId")]
        [Required]
        public long ColadoradorOSId { get; set; }
        [Column("ColaboradorId")]
        [Required]
        public long ColaboradorId { get; set; }
        [Column("OSId")]
        [Required]
        public long OSId { get; set; }

        [ForeignKey("ColaboradorId")]
        public Colaborador Colaborador { get; set; }
        [ForeignKey("OSId")]
        public OrdemServico OS { get; set; }
    }

}

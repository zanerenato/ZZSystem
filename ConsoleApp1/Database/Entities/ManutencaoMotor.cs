using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("ManutencoesMotores")]
    public class ManutencaoMotor
    {
        [Key]
        [Column("ManutencaoMotorId")]
        [Required]
        public long ManutencaoMotorId { get; set; }
        [Column("ManutencaoId")]
        [Required]
        public long ManutencaoId { get; set; }
        [Column("MotorId")]
        [Required]
        public long MotorId { get; set; }

        [ForeignKey("ManutencaoId")]
        public Manutencao Manutencao { get; set; }
        [ForeignKey("MotorId")]
        public Motor Motor { get; set; }
    }

}

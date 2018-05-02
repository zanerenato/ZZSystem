using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("Climatizadores")]
    public class Climatizador
    {
        [Key]
        [Column("ClimatizadorId")]
        [Required]
        public long ClimatizadorId { get; set; }
        [Column("NrClimatizador")]
        public int? NrClimatizador { get; set; }
        [Column("ClienteId")]
        [Required]
        public long ClienteId { get; set; }
        [Column("MotorId")]
        public long? MotorId { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }
        [ForeignKey("MotorId")]
        public Motor Motor { get; set; }

        [InverseProperty("Climatizador")]
        public List<ManutencaoClimatizador> Manutencoes { get; set; }

    }

}

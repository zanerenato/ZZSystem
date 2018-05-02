using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("ManutencoesMaquinas")]
    public class ManutencaoMaquina
    {
        [Key]
        [Column("ManutencaoMaquinaId")]
        [Required]
        public long ManutencaoMaquinaId { get; set; }
        [Column("ManutencaoId")]
        [Required]
        public long ManutencaoId { get; set; }
        [Column("MaquinaId")]
        [Required]
        public long MaquinaId { get; set; }

        [ForeignKey("ManutencaoId")]
        public Manutencao Manutencao { get; set; }
        [ForeignKey("MaquinaId")]
        public Maquina Maquina { get; set; }
    }

}

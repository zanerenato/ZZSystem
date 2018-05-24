using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("OSClimatizadores")]
    public class OSClimatizador
    {
        [Key]
        [Column("OSClimatizadorId")]
        [Required]
        public long OSClimatizadorId { get; set; }
        [Column("OSId")]
        [Required]
        public long OSId { get; set; }
        [Column("Adesivo")]
        public bool? Adesivo { get; set; }
        [Column("LimpezaCalha")]
        public bool? LimpezaCalha { get; set; }
        [Column("LimpezaGrelha")]
        public bool? LimpezaGrelha { get; set; }

        [ForeignKey("OSId")]
        public OrdemServico OS { get; set; }

        [InverseProperty("OSClimatizador")]
        public List<ManutencaoClimatizador> Manutencoes { get; set; }

    }

}

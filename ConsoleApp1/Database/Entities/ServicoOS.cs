using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("ServicosOS")]
    public class ServicoOS
    {
        [Key]
        [Column("ServicoOSId")]
        [Required]
        public long ServicoOSId { get; set; }
        [Column("ServicoId")]
        [Required]
        public long ServicoId { get; set; }
        [Column("OSId")]
        [Required]
        public long OSId { get; set; }
        [Column("Quantidade")]
        public int? Quantidade { get; set; }

        [ForeignKey("ServicoId")]
        public Servico Servico { get; set; }
        [ForeignKey("OSId")]
        public OrdemServico OS { get; set; }
    }

}

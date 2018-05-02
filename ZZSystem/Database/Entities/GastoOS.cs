using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("GastosOS")]
    public class GastoOS
    {
        [Key]
        [Column("GastoOSId")]
        [Required]
        public long GastoOSId { get; set; }
        [Column("OSId")]
        [Required]
        public long OSId { get; set; }
        [Column("TransacaoId")]
        [Required]
        public long TransacaoId { get; set; }
        [Column("Descricao")]
        [MaxLength]
        public string Descricao { get; set; }

        [ForeignKey("OSId")]
        public OrdemServico OS { get; set; }
        [ForeignKey("TransacaoId")]
        public Transacao Transacao { get; set; }

    }

}

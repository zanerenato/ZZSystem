using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("ContasReceber")]
    public class ContaReceber
    {
        [Key]
        [Column("ContaReceberId")]
        [Required]
        public long ContaReceberId { get; set; }
        [Column("NFId")]
        public int? NFId { get; set; }
        [Column("TransacaoId")]
        public long? TransacaoId { get; set; }
        [Column("Descricao")]
        [MaxLength]
        public string Descricao { get; set; }

        [ForeignKey("NFId")]
        public NF NF { get; set; }
        [ForeignKey("TransacaoId")]
        public Transacao Transacao { get; set; }
    }

}

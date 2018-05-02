using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("ContasPagar")]
    public class ContaPagar
    {
        [Key]
        [Column("ContaPagarId")]
        [Required]
        public long ContaPagarId { get; set; }
        [Column("CompraId")]
        public long? CompraId { get; set; }
        [Column("TransacaoId")]
        public long? TransacaoId { get; set; }
        [Column("NrDocumento")]
        public long? NrDocumento { get; set; }
        [Column("Descricao")]
        [MaxLength]
        public string Descricao { get; set; }

        [ForeignKey("CompraId")]
        public Compra Compra { get; set; }
        [ForeignKey("TransacaoId")]
        public Transacao Transacao { get; set; }
    }

}

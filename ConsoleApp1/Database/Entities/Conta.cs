using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("Contas")]
    public class Conta
    {
        [Key]
        [Column("ContaId")]
        [Required]
        public long ContaId { get; set; }
        [Column("Descricao")]
        [MaxLength]
        public string Descricao { get; set; }
        [Column("TipoContaId")]
        [Required]
        public int TipoContaId { get; set; }
        [Column("Banco")]
        public int? Banco { get; set; }
        [Column("Agencia")]
        public int? Agencia { get; set; }
        [Column("Conta")]
        public long? ContaNr { get; set; }

        [ForeignKey("TipoContaId")]
        public TipoConta TipoConta { get; set; }
    }

}

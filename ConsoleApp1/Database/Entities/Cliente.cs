using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        [Column("ClienteId")]
        [Required]
        public long ClienteId { get; set; }
        [Column("RazaoSocial")]
        [MaxLength]
        public string RazaoSocial { get; set; }
        [Column("CNPJ")]
        [Required]
        public long CNPJ { get; set; }
        [Column("FilialNr")]
        public int? FilialNr { get; set; }
        [Column("Contato")]
        [MaxLength]
        public string Contato { get; set; }
        [Column("DadosBasicosId")]
        public long? DadosBasicosId { get; set; }
        [Column("CodigoObra")]
        public int? CodigoObra { get; set; }

        [ForeignKey("DadosBasicosId")]
        public DadosBasicos DadosBasicos { get; set; }
    }

}

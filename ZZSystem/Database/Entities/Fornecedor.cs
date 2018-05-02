using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("Fornecedores")]
    public class Fornecedor
    {
        [Key]
        [Column("FornecedorId")]
        [Required]
        public long FornecedorId { get; set; }
        [Column("RazaoSocial")]
        [MaxLength]
        public string RazaoSocial { get; set; }
        [Column("CNPJ")]
        [Required]
        public long CNPJ { get; set; }
        [Column("Contato")]
        [MaxLength]
        public string Contato { get; set; }
        [Column("DadosBasicosId")]
        public long? DadosBasicosId { get; set; }

        [ForeignKey("DadosBasicosId")]
        public DadosBasicos DadosBasicos { get; set; }
    }

}

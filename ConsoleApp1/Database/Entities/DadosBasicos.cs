using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("DadosBasicos")]
    public class DadosBasicos
    {
        [Key]
        [Column("DadosBasicosId")]
        [Required]
        public long DadosBasicosId { get; set; }
        [Column("Endereco")]
        [MaxLength]
        public string Endereco { get; set; }
        [Column("Numero")]
        public int? Numero { get; set; }
        [Column("Bairro")]
        [MaxLength]
        public string Bairro { get; set; }
        [Column("CEP")]
        public int? CEP { get; set; }
        [Column("Cidade")]
        [MaxLength]
        public string Cidade { get; set; }
        [Column("UF")]
        [MaxLength]
        public string UF { get; set; }
        [Column("Pais")]
        [MaxLength]
        public string Pais { get; set; }
        [Column("TelefoneFixo")]
        public long? TelefoneFixo { get; set; }
        [Column("Celular")]
        public long? Celular { get; set; }
        [Column("Email")]
        [MaxLength]
        public string Email { get; set; }
    }


}
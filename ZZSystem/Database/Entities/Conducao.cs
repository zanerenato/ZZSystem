using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("Conducoes")]
    public class Conducao
    {
        [Key]
        [Column("ConducaoId")]
        [Required]
        public long ConducaoId { get; set; }
        [Column("Marca")]
        [Required]
        [MaxLength]
        public string Marca { get; set; }
        [Column("Modelo")]
        [Required]
        [MaxLength]
        public string Modelo { get; set; }
        [Column("Cor")]
        [Required]
        [MaxLength]
        public string Cor { get; set; }
        [Column("Placa")]
        [Required]
        [MaxLength]
        public string Placa { get; set; }
        [Column("Rendimento")]
        public decimal? Rendimento { get; set; }
        [Column("Km")]
        public decimal? Km { get; set; }
        [Column("DataCompraId")]
        public long? DataCompraId { get; set; }
        [Column("Valor")]
        public decimal? Valor { get; set; }

        [ForeignKey("DataCompraId")]
        public Data DataCompra { get; set; }
    }

}

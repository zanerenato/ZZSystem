using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("Maquinas")]
    public class Maquina
    {
        [Key]
        [Column("MaquinaId")]
        [Required]
        public long MaquinaId { get; set; }
        [Column("Descricao")]
        [MaxLength]
        public string Descricao { get; set; }
        [Column("Marca")]
        [MaxLength]
        public string Marca { get; set; }
        [Column("ColaboradorId")]
        public long? ColaboradorId { get; set; }
        [Column("TipoMaquinaId")]
        [Required]
        public int TipoMaquinaId { get; set; }
        [Column("DataCompraId")]
        public long? DataCompraId { get; set; }
        [Column("Valor")]
        public decimal? Valor { get; set; }

        [ForeignKey("ColaboradorId")]
        public Colaborador Colaborador { get; set; }
        [ForeignKey("TipoMaquinaId")]
        public TipoMaquina TipoMaquina { get; set; }
        [ForeignKey("DataCompraId")]
        public Data DataCompra { get; set; }
    }

}

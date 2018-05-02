using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("Motores")]
    public class Motor
    {
        [Key]
        [Column("MotorId")]
        [Required]
        public long MotorId { get; set; }
        [Column("NrMotor")]
        public long? NrMotor { get; set; }
        [Column("Marca")]
        [MaxLength]
        public string Marca { get; set; }
        [Column("Modelo")]
        [MaxLength]
        public string Modelo { get; set; }
        [Column("Tensao")]
        public int? Tensao { get; set; }
        [Column("Potencia")]
        public int? Potencia { get; set; }
        [Column("Valor")]
        public decimal? Valor { get; set; }
        [Column("DataCompraId")]
        public long? DataCompraId { get; set; }

        [ForeignKey("DataCompraId")]
        public Data DataCompra { get; set; }
    }

}

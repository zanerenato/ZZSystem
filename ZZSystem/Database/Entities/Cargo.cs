using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("Cargos")]
    public class Cargo
    {
        [Key]
        [Column("CargoId")]
        [Required]
        public long CargoId { get; set; }
        [Column("Funcao")]
        [MaxLength]
        public string Funcao { get; set; }
        [Column("Salario")]
        public decimal? Salario { get; set; }
        [Column("Vale")]
        public decimal? Vale { get; set; }
        [Column("FGTS")]
        public decimal? FGTS { get; set; }
        [Column("INSS")]
        public decimal? INSS { get; set; }
        [Column("ValeAlimentacao")]
        public decimal? ValeAlimentacao { get; set; }
        [Column("ValeTransporte")]
        public decimal? ValeTransporte { get; set; }
        [Column("AuxilioMoradia")]
        public decimal? AuxilioMoradia { get; set; }
        [Column("OutrosBeneficios")]
        public decimal? OutrosBeneficios { get; set; }
    }

}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("Horas")]
    public class Time
    {
        [Key]
        [Column("HoraId")]
        [Required]
        public long HoraId { get; set; }
        [Column("Hora")]
        [Required]
        public int Hora { get; set; }
        [Column("Minuto")]
        [Required]
        public int Minuto { get; set; }
    }


}

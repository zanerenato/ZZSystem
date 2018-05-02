using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("Logs")]
    public class Log
    {
        [Key]
        [Column("LogId")]
        [Required]
        public long LogId { get; set; }
        [Column("TabelaId")]
        [Required]
        public int TabelaId { get; set; }
        [Column("RegistroId")]
        [Required]
        public long RegistroId { get; set; }
        [Column("UserId")]
        [Required]
        public long UserId { get; set; }
        [Column("DataId")]
        [Required]
        public long DataId { get; set; }
        [Column("HoraId")]
        [Required]
        public long HoraId { get; set; }

        [ForeignKey("TabelaId")]
        public Tabela Tabela { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        [ForeignKey("DataId")]
        public Data Data { get; set; }
        [ForeignKey("HoraId")]
        public Time Hora { get; set; }
    }

}

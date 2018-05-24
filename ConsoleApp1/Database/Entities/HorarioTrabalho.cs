using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("HorariosTrabalho")]
    public class HorarioTrabalho
    {
        [Key]
        [Column("HorarioTrabalhoId")]
        [Required]
        public long HorarioTrabalhoId { get; set; }
        [Column("OSId")]
        [Required]
        public long OSId { get; set; }
        [Column("DataId")]
        [Required]
        public long DataId { get; set; }
        [Column("HoraInicio")]
        [Required]
        public long HoraInicioId { get; set; }
        [Column("HoraInicioAlmoco")]
        [Required]
        public long HoraInicioAlmocoId { get; set; }
        [Column("HoraFimAlmoco")]
        [Required]
        public long HoraFimAlmocoId { get; set; }
        [Column("HoraFim")]
        [Required]
        public long HoraFimId { get; set; }

        [ForeignKey("OSId")]
        public OrdemServico OS { get; set; }
        [ForeignKey("DataId")]
        public Data Data { get; set; }
        [ForeignKey("HoraInicioId")]
        public Time HoraInicio { get; set; }
        [ForeignKey("HoraInicioAlmocoId")]
        public Time HoraInicioAlmoco { get; set; }
        [ForeignKey("HoraFimAlmocoId")]
        public Time HoraFimAlmoco { get; set; }
        [ForeignKey("HoraFimId")]
        public Time HoraFim { get; set; }

    }

}

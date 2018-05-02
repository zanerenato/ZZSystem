using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("ManutencoesClimatizadores")]
    public class ManutencaoClimatizador
    {
        [Key]
        [Column("ManutencaoClimatizadorId")]
        [Required]
        public long ManutencaoClimatizadorId { get; set; }
        [Column("ClimatizadorId")]
        [Required]
        public long ClimatizadorId { get; set; }
        [Column("OSClimatizadorId")]
        [Required]
        public long OSClimatizadorId { get; set; }
        [Column("TrocaBomba")]
        public long? TrocaBomba { get; set; }
        [Column("TrocaEixo")]
        public long? TrocaEixo { get; set; }
        [Column("TrocaNucleo")]
        public long? TrocaNucleo { get; set; }
        [Column("TrocaValvula")]
        public long? TrocaValvula { get; set; }
        [Column("TrocaTela")]
        public long? TrocaTela { get; set; }
        [Column("TrocaManta")]
        public long? TrocaManta { get; set; }
        [Column("TrocaColmeia")]
        public long? TrocaColmeia { get; set; }
        [Column("SubstituirColmeiaProxima")]
        public bool? SubstituirColmeiaProxima { get; set; }
        [Column("Observacoes")]
        [MaxLength]
        public string Observacoes { get; set; }
        [Column("ObservacoesProxima")]
        [MaxLength]
        public string ObservacoesProxima { get; set; }

        [ForeignKey("ClimatizadorId")]
        public Climatizador Climatizador { get; set; }
        [ForeignKey("OSClimatizadorId")]
        public OSClimatizador OSClimatizador { get; set; }
    }

}

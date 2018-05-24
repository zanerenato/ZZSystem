using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("Colaboradores")]
    public class Colaborador
    {
        [Key]
        [Column("ColaboradorId")]
        [Required]
        public long ColaboradorId { get; set; }
        [Column("Nome")]
        [MaxLength]
        public string Nome { get; set; }
        [Column("TipoColaboradorId")]
        public int? TipoColaboradorId { get; set; }
        [Column("CargoId")]
        public long? CargoId { get; set; }
        [Column("RG")]
        [Required]
        public long RG { get; set; }
        [Column("CPF")]
        [Required]
        public long CPF { get; set; }
        [Column("EstadoCivil")]
        [MaxLength]
        public string EstadoCivil { get; set; }
        [Column("DadosBasicosId")]
        public long? DadosBasicosId { get; set; }
        [Column("DataNascimentoId")]
        public long? DataNascimentoId { get; set; }
        [Column("DataAdmissaoId")]
        public long? DataAdmissaoId { get; set; }

        [ForeignKey("TipoColaboradorId")]
        public TipoColaborador TipoColaborador { get; set; }
        [ForeignKey("DadosBasicosId")]
        public DadosBasicos DadosBasicos { get; set; }
        [ForeignKey("DataNascimentoId")]
        public Data DataNascimento { get; set; }
        [ForeignKey("DataAdmissaoId")]
        public Data DataAdmissao { get; set; }
    }

}

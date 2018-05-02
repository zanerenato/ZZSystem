using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("Orcamentos")]
    public class Orcamento
    {
        [Key]
        [Column("OrcamentoId")]
        [Required]
        public long OrcamentoId { get; set; }
        [Column("ClienteId")]
        public long? ClienteId { get; set; }
        [Column("TipoServicoId")]
        [Required]
        public int TipoServicoId { get; set; }
        [Column("Descricao")]
        [MaxLength]
        public string Descricao { get; set; }
        [Column("DataProgramadaId")]
        public long? DataProgramadaId { get; set; }
        [Column("DataOrcamentoId")]
        public long? DataOrcamentoId { get; set; }
        [Column("Valor")]
        public decimal? Valor { get; set; }
        [Column("HoraEstimadaId")]
        public long? HoraEstimadaId { get; set; }
        [Column("TempoEstimadoId")]
        public long? TempoEstimadoId { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }
        [ForeignKey("TipoServicoId")]
        public TipoServico TipoServico { get; set; }
        [ForeignKey("DataProgramadaId")]
        public Data DataProgramada { get; set; }
        [ForeignKey("DataOrcamentoId")]
        public Data DataOrcamento { get; set; }
        [ForeignKey("HoraEstimadaId")]
        public Time HoraEstimada { get; set; }

        //Quantidade de dias, semanas de duracao do servico
        [ForeignKey("TempoEstimadoId")]
        public Data TempoEstimado { get; set; }


        public List<MaterialOrcamento> MateriaisOrcamentos { get; set; }
        public List<Produto> Produtos { get; set; }
        public List<ServicoOrcamento> ServicosOrcamentos { get; set; }
        public List<Servico> Servicos { get; set; }

        public Orcamento()
        {
            MateriaisOrcamentos = new List<MaterialOrcamento>();
            Produtos = new List<Produto>();
            ServicosOrcamentos = new List<ServicoOrcamento>();
            Servicos = new List<Servico>();
        }

    }

}

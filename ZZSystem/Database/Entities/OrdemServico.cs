using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("OrdensServico")]
    public class OrdemServico
    {
        [Key]
        [Column("OrdemServicoId")]
        [Required]
        public long OrdemServicoId { get; set; }
        [Column("OrcamentoId")]
        public long? OrcamentoId { get; set; }
        [Column("ClienteId")]
        [Required]
        public long ClienteId { get; set; }
        [Column("TipoServicoId")]
        [Required]
        public int TipoServicoId { get; set; }
        [Column("ConducaoId")]
        public long? ConducaoId { get; set; }
        [Column("DataProximaManutencaoId")]
        public long? DataProximaManutencaoId { get; set; }
        [Column("Observacoes")]
        [MaxLength]
        public string Observacoes { get; set; }
        [Column("CustoTerceirizado")]
        public decimal? CustoTerceirizado { get; set; }

        [ForeignKey("OrcamentoId")]
        public Orcamento Orcamento { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }
        [ForeignKey("TipoServicoId")]
        public TipoServico TipoServico { get; set; }
        [ForeignKey("ConducaoId")]
        public Conducao Conducao { get; set; }
        [ForeignKey("DataProximaManutencaoId")]
        public Data DataProximaManutencao { get; set; }

        //private List<MaterialOS> MateriaisOs { get; set; }
        //public List<Estoque> Estoques { get; set; }
        private List<ServicoOS> ServicosOs { get; set; }
        public List<Servico> Servicos { get; set; }
        private List<ColaboradorOS> ColaboradoresOs { get; set; }
        public List<Colaborador> Colaboradores { get; set; }

        [InverseProperty("OS")]
        public List<OSClimatizador> OSClimatizadores { get; set; }
        [InverseProperty("OS")]
        public List<GastoOS> GastosOS { get; set; }
        [InverseProperty("OS")]
        public List<HorarioTrabalho> HorariosTrabalho { get; set; }
        [InverseProperty("OS")]
        public List<Estoque> Estoques { get; set; }


        public OrdemServico()
        {
            //MateriaisOs = new List<MaterialOS>();
            Estoques = new List<Estoque>();
            ServicosOs = new List<ServicoOS>();
            Servicos = new List<Servico>();
            OSClimatizadores = new List<OSClimatizador>();
            GastosOS = new List<GastoOS>();
            HorariosTrabalho = new List<HorarioTrabalho>();
        }
    }

}

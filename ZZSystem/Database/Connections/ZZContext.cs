using System;
using ZZSystem.Database.Entities;

using Microsoft.EntityFrameworkCore;

namespace ZZSystem.Database.Connections
{
    public class ZZContext : DbContext
    {
        public virtual DbSet<Cargo> Cargos { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Climatizador> Climatizadores { get; set; }
        public virtual DbSet<Colaborador> Colaboradores { get; set; }
        public virtual DbSet<ColaboradorOS> ColaboradoresOS { get; set; }
        public virtual DbSet<Compra> Compras { get; set; }
        public virtual DbSet<Conducao> Conducoes { get; set; }
        public virtual DbSet<Conta> Contas { get; set; }
        public virtual DbSet<ContaPagar> ContasPagar { get; set; }
        public virtual DbSet<ContaReceber> ContasReceber { get; set; }
        public virtual DbSet<DadosBasicos> DadosBasicos { get; set; }
        public virtual DbSet<Data> Datas { get; set; }
        public virtual DbSet<DepositoEstoque> DepositosEstoque { get; set; }
        public virtual DbSet<Estoque> Estoques { get; set; }
        public virtual DbSet<Fornecedor> Fornecedors { get; set; }
        public virtual DbSet<GastoOS> GastosOS { get; set; }
        public virtual DbSet<HorarioTrabalho> HorariosTrabalho { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Imposto> Impostos { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Logins> Logins { get; set; }
        public virtual DbSet<Manutencao> Manutencoes { get; set; }
        public virtual DbSet<ManutencaoClimatizador> ManutencoesClimatizadores { get; set; }
        public virtual DbSet<ManutencaoConducao> ManutencoesConducoes { get; set; }
        public virtual DbSet<ManutencaoMaquina> ManutencoesMaquinas { get; set; }
        public virtual DbSet<ManutencaoMotor> ManutencoesMotores { get; set; }
        public virtual DbSet<Maquina> Maquinas { get; set; }
        public virtual DbSet<MaterialOrcamento> MateriaisOrcamentos { get; set; }
        public virtual DbSet<MaterialServico> MateriaisServicos { get; set; }
        public virtual DbSet<Motor> Motores { get; set; }
        public virtual DbSet<NF> NFs { get; set; }
        public virtual DbSet<Orcamento> Orcamentos { get; set; }
        public virtual DbSet<OrdemServico> OrdensServico { get; set; }
        public virtual DbSet<OSClimatizador> OSClimatizadores { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<Salario> Salarios { get; set; }
        public virtual DbSet<Servico> Servicos { get; set; }
        public virtual DbSet<ServicoOrcamento> ServicosOrcamentos { get; set; }
        public virtual DbSet<ServicoOS> ServicosOS { get; set; }
        public virtual DbSet<Tabela> Tabelas { get; set; }
        public virtual DbSet<TipoColaborador> TiposColaboradores { get; set; }
        public virtual DbSet<TipoConta> TiposContas { get; set; }
        public virtual DbSet<TipoDespesa> TiposDespesas { get; set; }
        public virtual DbSet<TipoManutencao> TiposManutencoes { get; set; }
        public virtual DbSet<TipoMaquina> TiposMaquinas { get; set; }
        public virtual DbSet<TipoSalario> TiposSalarios { get; set; }
        public virtual DbSet<TipoServico> TiposServicos { get; set; }
        public virtual DbSet<TipoTransacao> TiposTransacoes { get; set; }
        public virtual DbSet<Transacao> Transacoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Console.WriteLine("Configurando Conexao");

            const string connection = "Data Source=zzdatabase.c3dqaybg3ze6.us-east-2.rds.amazonaws.com,1433;Initial Catalog=zzdatabase;" +
                                      "User ID=zz;Password=Zane2011";
            
            optionsBuilder.UseSqlServer(connection);
            base.OnConfiguring(optionsBuilder);
        }
    }
}

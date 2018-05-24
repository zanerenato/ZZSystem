using System;
using System.Collections;
using ZZSystem.Database.Entities;

namespace ZZSystem.Database.Connections
{
    public class DbAccess : IDisposable
    {

        private readonly ZZContext _context;
        private bool _disposed;

        public Repository<Cargo> Cargos { get; set; }
        public Repository<Cliente> Clientes { get; set; }
        public Repository<Climatizador> Climatizadores { get; set; }
        public Repository<Colaborador> Colaboradores { get; set; }
        public Repository<ColaboradorOS> ColaboradoresOS { get; set; }
        public Repository<Compra> Compras { get; set; }
        public Repository<Conducao> Conducoes { get; set; }
        public Repository<Conta> Contas { get; set; }
        public Repository<ContaPagar> ContasPagar { get; set; }
        public Repository<ContaReceber> ContasReceber { get; set; }
        public Repository<DadosBasicos> DadosBasicos { get; set; }
        public Repository<Data> Datas { get; set; }
        public Repository<DepositoEstoque> DepositosEstoque { get; set; }
        public Repository<Estoque> Estoques { get; set; }
        public Repository<Fornecedor> Fornecedors { get; set; }
        public Repository<GastoOS> GastosOS { get; set; }
        public Repository<Time> Horas { get; set; }
        public Repository<HorarioTrabalho> HorariosTrabalho { get; set; }
        public Repository<User> Users { get; set; }
        public Repository<Imposto> Impostos { get; set; }
        public Repository<Log> Logs { get; set; }
        public Repository<Logins> Logins { get; set; }
        public Repository<Manutencao> Manutencoes { get; set; }
        public Repository<ManutencaoClimatizador> ManutencoesClimatizadores { get; set; }
        public Repository<ManutencaoConducao> ManutencoesConducoes { get; set; }
        public Repository<ManutencaoMaquina> ManutencoesMaquinas { get; set; }
        public Repository<ManutencaoMotor> ManutencoesMotores { get; set; }
        public Repository<Maquina> Maquinas { get; set; }
        public Repository<MaterialOrcamento> MateriaisOrcamentos { get; set; }
        public Repository<MaterialServico> MateriaisServicos { get; set; }
        public Repository<Motor> Motores { get; set; }
        public Repository<NF> NFs { get; set; }
        public Repository<Orcamento> Orcamentos { get; set; }
        public Repository<OrdemServico> OrdensServico { get; set; }
        public Repository<OSClimatizador> OSClimatizadores { get; set; }
        public Repository<Produto> Produtos { get; set; }
        public Repository<Salario> Salarios { get; set; }
        public Repository<Servico> Servicos { get; set; }
        public Repository<ServicoOrcamento> ServicosOrcamentos { get; set; }
        public Repository<ServicoOS> ServicosOS { get; set; }
        public Repository<Tabela> Tabelas { get; set; }
        public Repository<TipoColaborador> TiposColaboradores { get; set; }
        public Repository<TipoConta> TiposContas { get; set; }
        public Repository<TipoDespesa> TiposDespesas { get; set; }
        public Repository<TipoManutencao> TiposManutencoes { get; set; }
        public Repository<TipoMaquina> TiposMaquinas { get; set; }
        public Repository<TipoSalario> TiposSalarios { get; set; }
        public Repository<TipoServico> TiposServicos { get; set; }
        public Repository<TipoTransacao> TiposTransacoes { get; set; }
        public Repository<Transacao> Transacoes { get; set; }

        public DbAccess()
        {
            _context = new ZZContext();
            _disposed = false;
            InitializeRepositories();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void InitializeRepositories()
        {
            Cargos = new Repository<Cargo>(_context);
            Clientes = new Repository<Cliente>(_context);
            Climatizadores = new Repository<Climatizador>(_context);
            Colaboradores = new Repository<Colaborador>(_context);
            ColaboradoresOS = new Repository<ColaboradorOS>(_context);
            Compras = new Repository<Compra>(_context);
            Conducoes = new Repository<Conducao>(_context);
            Contas = new Repository<Conta>(_context);
            ContasPagar = new Repository<ContaPagar>(_context);
            ContasReceber = new Repository<ContaReceber>(_context);
            DadosBasicos = new Repository<DadosBasicos>(_context);
            Datas = new Repository<Data>(_context);
            DepositosEstoque = new Repository<DepositoEstoque>(_context);
            Estoques = new Repository<Estoque>(_context);
            Fornecedors = new Repository<Fornecedor>(_context);
            GastosOS = new Repository<GastoOS>(_context);
            Horas = new Repository<Time>(_context);
            HorariosTrabalho = new Repository<HorarioTrabalho>(_context);
            Users = new Repository<User>(_context);
            Impostos = new Repository<Imposto>(_context);
            Logs = new Repository<Log>(_context);
            Logins = new Repository<Logins>(_context);
            Manutencoes = new Repository<Manutencao>(_context);
            ManutencoesClimatizadores = new Repository<ManutencaoClimatizador>(_context);
            ManutencoesConducoes = new Repository<ManutencaoConducao>(_context);
            ManutencoesMaquinas = new Repository<ManutencaoMaquina>(_context);
            ManutencoesMotores = new Repository<ManutencaoMotor>(_context);
            Maquinas = new Repository<Maquina>(_context);
            MateriaisOrcamentos = new Repository<MaterialOrcamento>(_context);
            MateriaisServicos = new Repository<MaterialServico>(_context);
            Motores = new Repository<Motor>(_context);
            NFs = new Repository<NF>(_context);
            Orcamentos = new Repository<Orcamento>(_context);
            OrdensServico = new Repository<OrdemServico>(_context);
            OSClimatizadores = new Repository<OSClimatizador>(_context);
            Produtos = new Repository<Produto>(_context);
            Salarios = new Repository<Salario>(_context);
            Servicos = new Repository<Servico>(_context);
            ServicosOrcamentos = new Repository<ServicoOrcamento>(_context);
            ServicosOS = new Repository<ServicoOS>(_context);
            Tabelas = new Repository<Tabela>(_context);
            TiposColaboradores = new Repository<TipoColaborador>(_context);
            TiposContas = new Repository<TipoConta>(_context);
            TiposDespesas = new Repository<TipoDespesa>(_context);
            TiposManutencoes = new Repository<TipoManutencao>(_context);
            TiposMaquinas = new Repository<TipoMaquina>(_context);
            TiposSalarios = new Repository<TipoSalario>(_context);
            TiposServicos = new Repository<TipoServico>(_context);
            TiposTransacoes = new Repository<TipoTransacao>(_context);
            Transacoes = new Repository<Transacao>(_context);
        }
    }
}

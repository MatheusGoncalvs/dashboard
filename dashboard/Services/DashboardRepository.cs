using dashboard.Data;
using dashboard.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dashboard.Services
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly ApplicationDbContext db;

        public DashboardRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public int GetQuantidadePedidosEmitidos(DateTime dataInicial, DateTime dataFinal)
        {
            return db.pedido.Where(
                pedido => pedido.Id >= 0 && pedido.DataPedido >= dataInicial && pedido.DataPedido <= dataFinal
                ).Count();
        }

        public int GetQuantidadePedidosFaturados(DateTime dataInicial, DateTime dataFinal)
        {
            return db.pedido.Where(
                pedido => pedido.Faturado == true && pedido.DataPedido >= dataInicial && pedido.DataPedido <= dataFinal
                ).Count();
        }

        public PedidosFaturadosEmitidosViewModel GetQuantidadePedidosEmitidosxFaturados(DateTime dataInicial, DateTime dataFinal)
        {
            PedidosFaturadosEmitidosViewModel pedido = new PedidosFaturadosEmitidosViewModel();
            pedido.Faturados = GetQuantidadePedidosFaturados(dataInicial, dataFinal);
            pedido.Emitidos = GetQuantidadePedidosEmitidos(dataInicial, dataFinal);

            return pedido;
        }

        public double GetValorPedidosFaturados(DateTime dataInicial, DateTime dataFinal)
        {

            var pedidos = from pedido in db.pedido.ToList()
                          where pedido.Faturado == true && pedido.DataPedido >= dataInicial && pedido.DataPedido <= dataFinal
                          select pedido;

            return pedidos.Sum(p => p.Valor);
        }

        public double GetValorPedidosFaturadosHoje() {
            var pedidos = from pedido in db.pedido.ToList()
            where pedido.Faturado && pedido.DataPedido.Day == DateTime.Now.Day
            select pedido;

            return pedidos.Sum(p => p.Valor);
        }

        public IEnumerable<MovimentacaoViewModel> GetTodosVendedoresComSeusPedidos()
        {
            return db.pedido.
                            Join(db.vendedor, pedido => pedido.IdVendedor,
                                vendedor => vendedor.Id,
                            (pedido, vendedor) => new MovimentacaoViewModel
                            {
                                NomeVendedor = vendedor.Nome,
                                IdVendedor = vendedor.Id,
                                IdPedidoVendedor = pedido.IdVendedor,
                                ValorPedido = pedido.Valor,
                                DataPedido = pedido.DataPedido
                            }).ToList();
        }

        public IEnumerable<VendedoresViewModel> GetTotalVendasPorVendedor(DateTime dataInicial, DateTime dataFinal)
        {
            var movimentacoes = GetTodosVendedoresComSeusPedidos();

            var somaVendas = from movimentacao in movimentacoes
                             where movimentacao.DataPedido >= dataInicial && movimentacao.DataPedido <= dataFinal
                             orderby movimentacao.ValorPedido
                             group movimentacao by movimentacao.NomeVendedor into vendedorGroup
                             select new VendedoresViewModel
                             {
                                 Vendedor = vendedorGroup.Key,
                                 TotalVendas = vendedorGroup.Sum(x => x.ValorPedido)
                             };
            return somaVendas;
        }

        public IEnumerable<DashboardViewModel> GetData(DateTime dataInicial, DateTime dataFinal)
        {
            DashboardViewModel dados = new DashboardViewModel();
            dados.Pedidos = GetQuantidadePedidosEmitidosxFaturados(dataInicial, dataFinal);
            dados.Vendedores = GetTotalVendasPorVendedor(dataInicial, dataFinal);
            dados.SomaValorPedidos = GetValorPedidosFaturados(dataInicial, dataFinal);
            dados.SomaValorPedidosFaturadosHoje = GetValorPedidosFaturadosHoje();

            List<DashboardViewModel> dadosDashboard = new List<DashboardViewModel>();
            dadosDashboard.Add(dados);

            return dadosDashboard;
        }
    }
}

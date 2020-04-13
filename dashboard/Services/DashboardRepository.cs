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

        public int GetPedidosNaoFaturados()
        {
            return db.pedido.Where(pedido => pedido.Id == 0).Count();
        }

        public IEnumerable<MovimentacaoViewModel> GetVendedores()
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

        public IEnumerable<VendedoresViewModel> SomaPorGrupos(DateTime dataInicial, DateTime dataFinal)
        {
            var movimentacoes = GetVendedores();

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
    }
}

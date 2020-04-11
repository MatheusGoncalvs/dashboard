using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dashboard.Models;
using dashboard.ViewModel;

namespace dashboard.Services
{
    public class SqlDashboardData : IDashboardRepository
    {
        private readonly SOFCONContext db;

        public SqlDashboardData(SOFCONContext db)
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
                                ValorPedido = pedido.Valor

                            }).ToList();
        }

        public IEnumerable<VendedoresViewModel> SomaPorGrupos()
        {
            var movimentacoes = GetVendedores();

            var somaVendas = from vendedor in movimentacoes
                             orderby vendedor.ValorPedido
                             group vendedor by vendedor.NomeVendedor into vendedorGroup
                             select new VendedoresViewModel
                             {
                                 Vendedor = vendedorGroup.Key,
                                 TotalVendas = vendedorGroup.Sum(x => x.ValorPedido)
                             };
            return somaVendas;
        }

        public IEnumerable<VendedoresViewModel> SomaPorGruposSemana()
        {
            var movimentacoes = GetVendedores();

            var somaVendas = from vendedor in movimentacoes
                             orderby vendedor.ValorPedido
                             group vendedor by vendedor.NomeVendedor into vendedorGroup
                             select new VendedoresViewModel
                             {
                                 Vendedor = vendedorGroup.Key,
                                 TotalVendas = vendedorGroup.Sum(x => x.ValorPedido/ 5)
                             };
            return somaVendas;
        }
    }
}

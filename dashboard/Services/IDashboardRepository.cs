using dashboard.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dashboard.Services
{
    public interface IDashboardRepository
    {
        IEnumerable<MovimentacaoViewModel> GetTodosVendedoresComSeusPedidos();

        IEnumerable<DashboardViewModel> GetData(DateTime dataInicial, DateTime dataFinal);

        IEnumerable<VendedoresViewModel> GetTotalVendasPorVendedor(DateTime dataInicial, DateTime dataFinal);

        int GetQuantidadePedidosEmitidos(DateTime dataInicial, DateTime dataFinal);

        int GetQuantidadePedidosFaturados(DateTime dataInicial, DateTime dataFinal);

        PedidosFaturadosEmitidosViewModel GetQuantidadePedidosEmitidosxFaturados(DateTime dataInicial, DateTime dataFinal);

        double GetValorPedidosFaturados(DateTime dataInicial, DateTime dataFinal);
        double GetValorPedidosFaturadosHoje();
    }
}

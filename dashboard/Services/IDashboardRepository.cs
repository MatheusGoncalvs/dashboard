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
        IEnumerable<MovimentacaoViewModel> GetVendedores();

        IEnumerable<DashboardViewModel> GetData(DateTime dataInicial, DateTime dataFinal);

        IEnumerable<VendedoresViewModel> GetTotalVendasPorVendedor(DateTime dataInicial, DateTime dataFinal);

        int GetPedidosEmitidos(DateTime dataInicial, DateTime dataFinal);

        int GetPedidosFaturados(DateTime dataInicial, DateTime dataFinal);

        PedidosFaturadosEmitidosViewModel GetPedidosEmitidosxFaturados(DateTime dataInicial, DateTime dataFinal);
    }
}

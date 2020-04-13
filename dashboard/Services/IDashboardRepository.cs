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

        IEnumerable<VendedoresViewModel> SomaPorGrupos(DateTime dataInicial, DateTime dataFinal);

        int GetPedidosNaoFaturados();
    }
}

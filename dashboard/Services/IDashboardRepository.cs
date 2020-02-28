using dashboard.Models;
using dashboard.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dashboard.Services
{
    public interface IDashboardRepository
    {
        IEnumerable<MovimGimViewModel> GetVendedores();

        IEnumerable<VendedoresViewModel> SomaPorGrupos();

        int GetPedidosNaoFaturados();

        IEnumerable<VendedoresViewModel> SomaPorGruposSemana();
    }
}

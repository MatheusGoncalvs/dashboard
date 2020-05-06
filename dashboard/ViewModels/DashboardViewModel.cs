using System.Collections.Generic;

namespace dashboard.ViewModels
{
    public class DashboardViewModel
    {
        public PedidosFaturadosEmitidosViewModel Pedidos { get; set; }

        public IEnumerable<VendedoresViewModel> Vendedores { get; set; }

        public double SomaValorPedidos { get; set; }
        public double SomaValorPedidosFaturadosHoje { get; set; }
    }
}
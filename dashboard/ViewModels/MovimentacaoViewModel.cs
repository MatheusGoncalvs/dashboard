using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dashboard.ViewModels
{
    public class MovimentacaoViewModel
    {
        public int IdPedidoVendedor { get; set; }
        public int IdVendedor { get; set; }
        public string NomeVendedor { get; set; }
        public double ValorPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
    }
}

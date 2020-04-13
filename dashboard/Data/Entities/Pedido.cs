using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dashboard.Data.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public int IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public double Valor { get; set; }
        public bool Faturado { get; set; }
        public DateTime DataPedido { get; set; }
    }
}

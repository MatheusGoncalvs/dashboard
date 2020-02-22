using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dashboard.Models
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }

        public int IdItem { get; set; }

        public double QtdItem { get; set; }

        public int IdNfe { get; set; }

        public int IdCliente { get; set; }

        public DateTime DataEmissao { get; set; }

        public DateTime DataFaturamento { get; set; }
    }
}

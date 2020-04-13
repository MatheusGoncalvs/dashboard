using dashboard.Services;
using dashboard.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dashboard.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IDashboardRepository dashboardRepository;

        public DashboardController(IDashboardRepository dashboardRepository)
        {
            this.dashboardRepository = dashboardRepository;
        }

        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetVendedores(DateTime dataInicial, DateTime dataFinal)
        {
            if (dataInicial == dataFinal)
            {
                dataFinal = new DateTime(3000, 12, 31, 0, 0, 0);
            }

            var vendedores = dashboardRepository.SomaPorGrupos(dataInicial, dataFinal);

            return Json(vendedores);
        }

        [HttpPost]
        public IActionResult AtualizaData(DateTime DataInicial, DateTime DataFinal)
        {
            if (DataInicial == DataFinal)
            {
                DataFinal = new DateTime(3000, 12, 31, 0, 0, 0);
            }

            var vendedores = dashboardRepository.SomaPorGrupos(DataInicial, DataFinal);

            return Json(vendedores);
        }

        [HttpGet]
        public IActionResult GetPedidosNaoFaturados()
        {
            var qtdPedidos = dashboardRepository.GetPedidosNaoFaturados();

            PedidosNaoFaturadosViewModel pedido = new PedidosNaoFaturadosViewModel();
            pedido.Quantidade = qtdPedidos;

            return Json(pedido);
        }
    }
}

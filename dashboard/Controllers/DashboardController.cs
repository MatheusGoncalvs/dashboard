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
        public IActionResult AtualizaDados()
        {
            var dataInicial = new DateTime(2000, 01, 01, 0, 0, 0);
            var dataFinal = new DateTime(3000, 12, 31, 0, 0, 0);

            var dados = dashboardRepository.GetData(dataInicial, dataFinal);

            return Json(dados);
        }

        [HttpPost]
        public IActionResult AtualizaDados(DateTime DataInicial, DateTime DataFinal)
        {
            if (DataInicial == DataFinal)
            {
                DataFinal = new DateTime(3000, 12, 31, 0, 0, 0);
            }

            var dados = dashboardRepository.GetData(DataInicial, DataFinal);
            return Json(dados);
        }
    }
}

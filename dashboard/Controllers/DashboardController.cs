using dashboard.Services;
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
        public IActionResult GetVendedores()
        {
            var vendedores = dashboardRepository.SomaPorGrupos();

            return Json(vendedores);
        }

        [HttpGet]
        public IActionResult GetVendedoresSemana()
        {
            var vendedores = dashboardRepository.SomaPorGruposSemana();

            return Json(vendedores);
        }

    }
}

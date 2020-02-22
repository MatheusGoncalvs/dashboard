using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dashboard.Services;

namespace dashboard.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDashboardRepository dashboardRepository;

        public HomeController(IDashboardRepository dashboardRepository)
        {
            this.dashboardRepository = dashboardRepository;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Dashboard", "Dashboard");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}


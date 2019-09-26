using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Provas_Online.Site.Controllers.ProfessorDashboard
{
    public class ProfessorDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Questao()
        {
            return View();
        }
    }
}
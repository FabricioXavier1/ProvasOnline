using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Provas_Online.Site.Models;

namespace Provas_Online.Site.Controllers.Login
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
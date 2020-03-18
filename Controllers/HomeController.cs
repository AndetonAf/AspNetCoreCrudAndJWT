using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Comeia.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Comeia.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login([Bind("Username,Password")] Auth auth)
        {
            if (auth.Username == "usuario" && auth.Password == "123456")
            {
                HttpContext.Session.SetString("logado", "true");
                return RedirectToRoute(new { controller = "Pessoas", action = "Index" });
            }
            else
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.SetString("logado", "false");
            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }

    }
}
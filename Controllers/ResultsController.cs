using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tp4.Models;

namespace TP4.Controllers {
    public class ResultsController : Controller {

        public IActionResult Index() {
            return View();
        }
        public IActionResult SelectIndumentaria() {
              return View();
        }
        public IActionResult GuardarIndumentaria (int Equipo, int Media, int Pantalon, int Remera) {
              return View();
        }
    }
}
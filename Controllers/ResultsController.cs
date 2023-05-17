using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tp4.Models;

namespace TP4.Controllers {
    public class ResultsController : Controller {

        public IActionResult Index() {
            string[] equipos = new string[1];
            equipos[0] = "boca";
            Indumentaria indu = new Indumentaria("medias" +  equipos[0],"pantalon" +  equipos[0],"remeras" +  equipos[0]);
            Equipos.IngresarIndumentaria("boca",indu);
            ViewBag.equipos = Equipos.EquiposIndumentaria;
            Console.WriteLine(Equipos.EquiposIndumentaria);
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
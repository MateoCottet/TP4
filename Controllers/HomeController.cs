using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tp4.Models;

namespace Tp4.Controllers;


public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.ListaEquipos  = Equipos.EquiposIndumentaria;
        return View();
    }
    public IActionResult SelectIndumentaria()
    {
        ViewBag.ListaEquipos= Equipos.ListaEquipos;
        ViewBag.ListaMedias= Equipos.ListaMedias;
        ViewBag.ListaPantalones= Equipos.ListaPantalones;
        ViewBag.ListaRemeras= Equipos.ListaRemeras;

        return View();
    }

    public IActionResult GuardarIndumentaria (string Equipo, IFormFile Media, IFormFile Pantalon, IFormFile Remera)
    {
         Equipos.ListaEquipos = new List<string>();
        Equipos.ListaMedias = new List<IFormFile>();
        Equipos.ListaPantalones = new List<IFormFile>();
        Equipos.ListaRemeras = new List<IFormFile>();
        Equipos.EquiposIndumentaria = new Dictionary<string, Indumentaria>();
        Equipos.ListaMedias.Add(Media);
        Equipos.ListaPantalones.Add(Pantalon);
        Equipos.ListaRemeras.Add(Remera);
        Indumentaria indu = new Indumentaria(Media,Pantalon,Remera);
        Equipos.IngresarIndumentaria(Equipo,indu);
        return RedirectToAction("Index");
    }
    public IActionResult meterImagen(string imagen) {
        
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}



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
        ViewBag.EquiposCreados  = Equipos.EquiposIndumentaria;
        return View();
    }
    public IActionResult SelectIndumentaria()
    {
        string[] equipos = new string[10];
        equipos[0] = "River";
        equipos[1] = "Sanlorenzo";
        equipos[2] = "Talleres";
        equipos[3] = "Defensayjusticia";
        equipos[4] = "Estudiantes";
        equipos[5] = "Rosariocentral";
        equipos[6] = "Belgrano";
        equipos[7] = "Lanus";
        equipos[8] = "Argentinosjuniors";
        equipos[9] = "Boca";
        ViewBag.ListaEquipos= Equipos.ListaEquipos;
        ViewBag.ListaMedias= Equipos.ListaMedias;
        ViewBag.ListaPantalones= Equipos.ListaPantalones;
        ViewBag.ListaRemeras= Equipos.ListaRemeras;
        ViewBag.Equipos = equipos;
        return View();
    }

    public IActionResult GuardarIndumentaria (string Equipo, string Media, string Pantalon, string Remera)
    {
        Equipos.ListaEquipos = new List<string>();
        Equipos.ListaMedias = new List<string>();
        Equipos.ListaPantalones = new List<string>();
        Equipos.ListaRemeras = new List<string>();
        Equipos.EquiposIndumentaria = new Dictionary<string, Indumentaria>();
        Equipos.ListaMedias.Add(Media);
        Equipos.ListaPantalones.Add(Pantalon);
        Equipos.ListaRemeras.Add(Remera);
        Indumentaria indu = new Indumentaria(Media,Pantalon,Remera);
        Equipos.IngresarIndumentaria(Equipo,indu);
        ViewBag.EquiposCreados = Equipos.EquiposIndumentaria;
        ViewBag.indu = indu;
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



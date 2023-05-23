using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tp4.Models;
using TuProyecto.Models;

namespace tp4.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

     public IActionResult Index()
        {
            var paises = Info.ListarPaises();
            ViewBag.Paises = paises;

            return View();
        }

     public IActionResult DetallePais(string pais)
        {
            ViewBag.Pais = Info.DetallePais(pais);
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

using Microsoft.AspNetCore.Mvc;
using SistemaControleLuminosidade.Models;
using SistemaControleLuminosidade.Repositore;
using System.Diagnostics;

namespace SistemaControleLuminosidade.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            LampadaRepositore Repositore = new LampadaRepositore();
            var lampadas = Repositore.BuscarLampadas();
            return View(lampadas);
        }

        public IActionResult Detalhes(int id_lampada)
        {
            LampadaRepositore Repositore = new LampadaRepositore();
            var lampada = Repositore.BuscarLampadaPorId(id_lampada);
            return View(lampada);
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
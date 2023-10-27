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

        public IActionResult CadastroLampada(int id_lampada)
        {
            return View();
        }

        public string CadastrarLampada(string nome)
        {
            return "";
        }

        public string BuscarSensores()
        {
            return "";
        }

        public string InformarComoQueimada(int id_lampada)
        {
            LampadaRepositore Repositore = new LampadaRepositore();
            var lampada = Repositore.BuscarLampadaPorId(id_lampada);
            Repositore.InformarComoQueimada(lampada);
            return "O status da lampada foi alterado para queimada";
        }
    }
}
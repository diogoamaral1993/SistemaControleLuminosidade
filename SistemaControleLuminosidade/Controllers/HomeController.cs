using Microsoft.AspNetCore.Mvc;
using SistemaControleLuminosidade.Models;
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
            tb_lampada lampada = new tb_lampada();
            lampada.id_lampada = 1;
            lampada.nome_lampada = "Lampada 1";
            lampada.Status = "Ligada";
            lampada.DataUltimaAtualizacao = DateTime.Now;
            return View(lampada);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
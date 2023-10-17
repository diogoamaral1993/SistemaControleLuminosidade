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
            List<tb_lampada> lampadas = new List<tb_lampada>();
            LampadaRepositore Repositore = new LampadaRepositore();

            lampadas = Repositore.BuscarLampadas();
            
            //lampadas.Add(new tb_lampada
            //{
            //   id_lampada = 1,
            //   nome_lampada = "Lampada 1",
            //   situacao_lampada = "Ligada",
            //   data_ultima_atualizacao = DateTime.Now
            //});

            //lampadas.Add(new tb_lampada
            //{
            //    id_lampada = 2,
            //    nome_lampada = "Lampada 2",
            //    situacao_lampada = "Desligada",
            //    data_ultima_atualizacao = Convert.ToDateTime("10/16/2023")
            //});

            return View(lampadas);
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
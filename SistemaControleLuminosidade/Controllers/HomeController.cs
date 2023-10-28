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

        public IActionResult CadastroLampada()
        {
            SensorRepositore Repositore = new SensorRepositore();
            var sensores = Repositore.BuscarSensoresFuncionando();
            return View(sensores);
        }

        public string CadastrarLampada(string nome_lampada, int id_sensor)
        {
            tb_lampada lampada = new tb_lampada();
            lampada.id_sensor = id_sensor;
            lampada.nome_lampada = nome_lampada;
            lampada.status_lampada = "Funcionando";
            lampada.situacao_lampada = "Desligado";
            lampada.data_inclusao = DateTime.Now;
            lampada.quantidade_vezes_ligacao = 0;
            LampadaRepositore Repositore = new LampadaRepositore();
            Repositore.CadastrarLampada(lampada);
            return "Lampada cadastrada com sucesso!";
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
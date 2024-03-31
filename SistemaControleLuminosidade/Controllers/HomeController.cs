using Microsoft.AspNetCore.Mvc;
using SistemaControleLuminosidade.Interfaces;
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

        public IActionResult PainelLampadas()
        {
            LampadaRepositore Repositore = new LampadaRepositore();
            var lampadas = Repositore.BuscarLampadas();
            return View(lampadas);
        }

        public IActionResult PainelSensores()
        {
            SensorRepositore Repositore = new SensorRepositore();
            var sensores = Repositore.BuscarSensores();
            return View(sensores);
        }

        public IActionResult PainelEstoque()
        {
            SensorRepositore RepositoreSensor = new SensorRepositore();
            var sensores = RepositoreSensor.BuscarSensoresEstoque();
            LampadaRepositore RepositoreLmapada = new LampadaRepositore();
            var lampadas = RepositoreLmapada.BuscarLampadasEstoque();

            List<IComponente> listaComponentes = new List<IComponente>();

            foreach (var sensor in sensores)
            {
                if (sensor.status_sensor == "No estoque")
                {
                    listaComponentes.Add(sensor);
                }
            }

            foreach (var lampada in lampadas)
            {
                if (lampada.status_lampada == "No estoque")
                {
                    listaComponentes.Add(lampada);
                }
            }

            return View(listaComponentes);
        }

        public IActionResult DetalhesLampada(int id_lampada)
        {
            LampadaRepositore Repositore = new LampadaRepositore();
            var lampada = Repositore.BuscarLampadaPorId(id_lampada);
            return View(lampada);
        }

        public IActionResult DetalhesSensor(int id_sensor)
        {
            SensorRepositore Repositore = new SensorRepositore();
            var sensor = Repositore.BuscarSensorPorId(id_sensor);
            ViewBag.ListaSensoresFuncionando = Repositore.BuscarSensoresSubstituicao(id_sensor);
            return View(sensor);
        }

        public IActionResult CadastroLampada()
        {
            SensorRepositore Repositore = new SensorRepositore();
            var sensores = Repositore.BuscarSensoresFuncionando();
            return View(sensores);
        }

        public IActionResult CadastroSensor()
        {
            return View();
        }

        public string CadastrarLampada(string nome_lampada, int id_sensor, string bloco)
        {
            tb_lampada lampada = new tb_lampada();
            lampada.id_sensor = id_sensor;
            lampada.nome = nome_lampada;
            lampada.status_lampada = "Funcionando";
            lampada.situacao_lampada = "Desligado";
            lampada.data_inclusao = DateTime.Now;
            lampada.quantidade_vezes_ligacao = 0;
            lampada.bloco = bloco;
            LampadaRepositore Repositore = new LampadaRepositore();
            Repositore.CadastrarLampada(lampada);
            return "Lampada cadastrada com sucesso!";
        }

        public string CadastrarSensor(string nome_sensor, string tipo_sensor, string bloco)
        {
            tb_sensor sensor = new tb_sensor();
            sensor.nome = nome_sensor;
            sensor.status_sensor = "Funcionando";
            sensor.data_inclusao = DateTime.Now;
            sensor.tipo_sensor = tipo_sensor;
            sensor.bloco = bloco;
            SensorRepositore Repositore = new SensorRepositore();
            Repositore.CadastrarSensor(sensor);
            return "Sensor cadastrado com sucesso!";
        }

        public string InformarLampadaComoQueimada(int id_lampada)
        {
            LampadaRepositore Repositore = new LampadaRepositore();
            var lampada = Repositore.BuscarLampadaPorId(id_lampada);
            Repositore.InformarComoQueimada(lampada);
            return "O status da lampada foi alterado para queimada";
        }

        public string InformarSensorComoQueimado(int id_sensor, int id_sensor_substituto)
        {
            SensorRepositore Repositore = new SensorRepositore();
            var sensor = Repositore.BuscarSensorPorId(id_sensor);
            if (id_sensor_substituto != 0 && sensor.tipo_sensor == "Luz") 
            {
                Repositore.SubstituirSensor(sensor, id_sensor_substituto);
            }
            else if(id_sensor_substituto == 0 && sensor.tipo_sensor == "Luz")
            {
                return "É necessário selecionar um sensor de luz substituto";
            }
            else if (id_sensor_substituto == 0 && sensor.tipo_sensor != "Luz")
            {
                Repositore.InformarComoQueimado(sensor);
            }

            return "O status do sensor foi alterado para queimado";
        }
    }
}
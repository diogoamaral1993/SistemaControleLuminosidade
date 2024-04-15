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

        public IActionResult Login()
        {
            return View();
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

        public IActionResult DetalhesCoponente(int id_componente, string tipo)
        {
            if (tipo == "Lampada")
            {
                LampadaRepositore repositore = new LampadaRepositore();
                var componente = repositore.BuscarLampadaPorId(id_componente);
                return View(componente);
            }
            else
            {
                SensorRepositore Repositore = new SensorRepositore();
                var componente = Repositore.BuscarSensorPorId(id_componente);
                return View(componente);

            }

        }

        public IActionResult CadastroLampada()
        {
            SensorRepositore RepositoreSensor = new SensorRepositore();
            LampadaRepositore RepositoreLampada = new LampadaRepositore();
            var sensores = RepositoreSensor.BuscarSensoresFuncionando();
            var lampadas = RepositoreLampada.BuscarLampadasEstoque();
            var Listas = new Tuple<List<tb_lampada>, List<tb_sensor>>(lampadas, sensores);
            return View(Listas);
        }

        public IActionResult CadastroSensor()
        {
            SensorRepositore repositore = new SensorRepositore();
            var sensores = repositore.BuscarSensoresEstoque();
            return View(sensores);
        }

        public string VincularLampada(int id_lampada, int id_sensor, string bloco)
        {
            LampadaRepositore Repositore = new LampadaRepositore();
            Repositore.TirarLmapadaEstoque(id_lampada, id_sensor, bloco);
            return "Lampada cadastrada com sucesso!";
        }

        public IActionResult CadastroCoponente()
        {
            return View();
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

        public string AtualizarComponenteEstoque(string nome_componente, int id_componente, string tipo)
        {
            if (tipo == "Lampada")
            {
                LampadaRepositore repositore = new LampadaRepositore();
                var componente = repositore.BuscarLampadaPorId(id_componente);
                repositore.AtualizarLampadaEstoque(componente, nome_componente);
            }
            else
            {
                SensorRepositore repositore = new SensorRepositore();
                var componente = repositore.BuscarSensorPorId(id_componente);
                componente.nome = nome_componente;
                repositore.AtualizarSensorEstoque(componente);
            }
            return "Atualizado com Sucesso!";
        }

        public string CadastrarComponente(string nome_componente, string tipo_sensor, string tipo_componente)
        {
            if (tipo_componente == "Lampada")
            {
                tb_lampada lampada = new tb_lampada();
                lampada.nome = nome_componente;
                lampada.status_lampada = "No estoque";
                lampada.data_inclusao = DateTime.Now;
                lampada.tipo = tipo_componente;
                lampada.situacao_lampada = "Desligado";
                LampadaRepositore Repositore = new LampadaRepositore();
                Repositore.CadastrarLampada(lampada);
            }
            else if (tipo_componente == "Sensor")
            {
                tb_sensor sensor = new tb_sensor();
                sensor.nome = nome_componente;
                sensor.status_sensor = "No estoque";
                sensor.data_inclusao = DateTime.Now;
                sensor.tipo_sensor = tipo_sensor;
                sensor.tipo = tipo_componente;
                SensorRepositore Repositore = new SensorRepositore();
                Repositore.CadastrarSensor(sensor);
            }


            return "Cadastrado com sucesso!";
        }


        public string CadastrarSensorEstoque(int id_sensor, string tipo_sensor, string bloco)
        {
            SensorRepositore Repositore = new SensorRepositore();
            var sensor = Repositore.BuscarSensorPorId(id_sensor);
            sensor.status_sensor = "Funcionando";
            sensor.tipo_sensor = tipo_sensor;
            sensor.bloco = bloco;

            Repositore.AtualizarSensorEstoque(sensor);

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
        else if (id_sensor_substituto == 0 && sensor.tipo_sensor == "Luz")
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